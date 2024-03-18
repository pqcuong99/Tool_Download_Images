using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tool_Download_Image_Inspireuplift.Controller;
using Tool_Download_Image_Inspireuplift.Controller.Etsy;
using Tool_Download_Image_Inspireuplift.Controller.InspireUplife;
using Tool_Download_Image_Inspireuplift.Model;
using Tool_Download_Image_Inspireuplift.Model.Etsy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tool_Download_Image_Inspireuplift
{
    public partial class Form1 : Form
    {
        int dem = 0;
        int pageEsty = 0;
        private string TypeRadioWebsite = "Inspireu Uplift";
        public Form1()
        {
            Chilkat.Global glob = new Chilkat.Global();
            bool success = glob.UnlockBundle("ADSVN8.CBX1124_zUkOHNdJpY9b");
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSlDownloadDone.Text = "";
            List<string> list = new List<string>();
            list.Add("Inspire Uplift");
            list.Add("Esty");
            //list.Add("Redbubble");
            //list.Add("Printify");
            //list.Add("Printdoors");
            //list.Add("Odoo");
            //list.Add("Customcat");
            //list.Add("Vectown");
            cbbType.DataSource = list;

            string exePath = Environment.CurrentDirectory;
            string dataForm = DownloadHelper.ReadOrCreateFile(exePath + "\\DataForm.txt");
            if(dataForm == "")
            {
                txtLinkShop.Text = "";
                txtNameSheet.Text = "";
                txtPathSave.Text = "";
                txtPathZip.Text = "";
                txtPrice.Text = "";
                txtProduct.Text = "";
            }
            else
            {
                string[] arrDataForm = dataForm.Split('|');
                txtLinkShop.Text = arrDataForm[0];
                txtPathSave.Text = arrDataForm[1];
                txtNameSheet.Text = arrDataForm[2];
                txtProduct.Text = arrDataForm[3];
                txtPrice.Text = arrDataForm[4];
                txtPathZip.Text = arrDataForm[5];
            }
        }
        public void SaveDataform()
        {
            string exePath = Environment.CurrentDirectory;

            string linkShop = txtLinkShop.Text.Trim();
            string pathSave = txtPathSave.Text.Trim();
            string nameSheet = txtNameSheet.Text.Trim();
            string product = txtProduct.Text.Trim();
            string price = txtPrice.Text.Trim();
            string pathZip = txtPathZip.Text.Trim();

            string dataFormSave = linkShop + "|" + pathSave + "|" + nameSheet + "|" + product + "|" + price + "|" + pathZip;
            DownloadHelper.WriteFileDataForm(exePath + "\\DataForm.txt", dataFormSave);
        }
        public string RegexShopName_Inspire()
        {
            string linkShop = txtLinkShop.Text.Trim();

            string shopName = "";
            string pattern = @"(?:shop\/)([^?]+)";

            Match match = Regex.Match(linkShop, pattern);

            if (match.Success)
            {
                shopName = match.Groups[1].Value;
            }
            return shopName;
        }
        public string RegexShopName_Etsy()
        {
            string linkShop = txtLinkShop.Text.Trim();

            string shopName = "";
            string pattern = @"(?:shop\/)([^?]+)";

            Match match = Regex.Match(linkShop, pattern);

            if (match.Success)
            {
                shopName = match.Groups[1].Value;
            }
            return shopName;
        }
        public string RegexSection_id_Etsy()
        {
            string linkShop = txtLinkShop.Text.Trim();

            string shopName = "";
            string pattern = @"section_id=(\d+)";

            Match match = Regex.Match(linkShop, pattern);

            if (match.Success)
            {
                shopName = match.Groups[1].Value;
            }
            return shopName;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            dem = 0;
            SaveDataform();
            richTextBox1.Text = "";
            Thread thread = new Thread(() =>
            {
                if (TypeRadioWebsite == "Inspire Uplift")
                {
                    int sumpage = GetSumPage();
                    string shopName = RegexShopName_Inspire();
                    string pathSave = txtPathSave.Text.Trim();
                    if (shopName != "")
                    {
                        for (int i = 1; i <= sumpage; i++)
                        {
                            RunGetDataShop(shopName, i, pathSave);
                        }
                    }
                }
                if (TypeRadioWebsite == "Esty")
                {
                    
                    RunDownload_Etsys();
                }
               
            });
            thread.IsBackground = true;
            thread.Start();
        }
        
        public void RunGetShopName()
        {
            string shopName = RegexShopName_Inspire();
            string pathSave = txtPathSave.Text.Trim();
            if (shopName != "")
            {
                RunGetDataShop(shopName, 1, pathSave);
            }
            
        }
        public int GetSumPage()
        {
            string shopName = RegexShopName_Inspire();
            if (shopName != "")
            {
                return  InspireUplife_Controller.GetSumPage(shopName);
            }
            return 1;
        }
        public void RunGetDataShop(string shopName,int page,string pathSave)
        {
            var cvRes = InspireUplife_Controller.GetDataShop(shopName,page);

            var arrLink = cvRes.pageProps.sellerData.data;

            pathSave = DownloadHelper.CreateFolder(pathSave,TypeRadioWebsite);
            
            RunDownloads(arrLink, pathSave, shopName, page);
        }
        public void RunDownloads(Datum1[] datas,string pathSave,string shopName, int page)
        {
            try
            {
                // khoi tao folder shop de luu anh
                pathSave = DownloadHelper.CreateFolder(pathSave, shopName);
                string pathExcel = pathSave + "\\DataExcel.xlsx";
                //khoi tao folder page
                pathSave = DownloadHelper.CreateFolder(pathSave, "page- " + page);
                string descriptions = "";
                string pathImages = "";
                foreach (var data in datas)
                {
                    dem++;
                    TimeSpan myDateResult = DateTime.Now.TimeOfDay;
                    string timeSpan_tostring = myDateResult.Ticks.ToString();

                    string path_ = pathSave + $"\\{timeSpan_tostring}.png";

                    //log status
                    LogStatusRichTetxbox(Color.Black, "running download : " + timeSpan_tostring+".png");

                    //download image
                    DownloadHelper.DownloadImage(data.featured_image.url, path_);

                   
                    //log status
                    LogStatusRichTetxbox(Color.Blue, "download done ------>: " + timeSpan_tostring + ".png");

                    LogStatusLable("Download done: " + dem + "");

                    descriptions += data.title + "\n";
                    pathImages += path_ + "\n";


                    SaveExcelData(pathExcel, data.title, path_);
                    //log status
                    LogStatusRichTetxbox(Color.Green, "--------SaveExcelData ------>: ");
                }
                DownloadHelper.SaveText(pathSave + "\\descriptions.txt", descriptions);
                DownloadHelper.SaveText(pathSave + "\\pathImages.txt", pathImages);
            }
            catch (Exception ex)
            {

            }
        }
        
        private void btnDownload1Page_Click(object sender, EventArgs e)
        {
            dem = 0;
            richTextBox1.Text = "";
            SaveDataform();
            Thread thread = new Thread(() =>
            {
                if(TypeRadioWebsite == "Inspire Uplift")
                {
                    RunGetShopName();
                }
                if(TypeRadioWebsite == "Esty")
                {
                    RunDownload_Etsy();
                }
                //if(TypeRadioWebsite == "Redbubble")
                //{
                //    Api_Custommer api_ = new Api_Custommer();
                //    api_.GetHTML_Image_Redbubble("rubyandpearl");
                //}
                
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public void RunDownload_Etsys()
        {
            dem = 0;
            pageEsty = 0;
            string regexNameShop = RegexShopName_Etsy();
            string regexSection_Id = RegexSection_id_Etsy();
            if (regexNameShop != "")
            {
                try
                {
                    string idShop = Etsy_Controller.Get_ID_shop_Etsy(regexNameShop);
                    if (idShop == string.Empty)
                    {
                        LogStatusLable("Get id shop error");
                        return;
                    }
                    LogStatusLable("Running Get HTML");
                    LogStatusRichTetxbox(Color.BlueViolet, "Running Get HTML");

                    List<Variable_Data_Image_GetHTML> listData = new List<Variable_Data_Image_GetHTML> ();
                    if(regexSection_Id == "")
                    {
                        listData = Etsy_Controller.GetListUrls_Etsy(regexNameShop, pageEsty, idShop);
                    }
                    else
                    {
                        listData = Etsy_Controller.GetListUrls_Etsy_Section_id(regexNameShop, 0, idShop, regexSection_Id);
                    }

                    LogStatusRichTetxbox(Color.BlueViolet, "Get HTML Done ----->");

                    string pathSave = txtPathSave.Text.Trim();

                    //tao folder type save
                    pathSave = DownloadHelper.CreateFolder(pathSave, TypeRadioWebsite);

                    //tao folder name shop
                    pathSave = DownloadHelper.CreateFolder(pathSave, regexNameShop);


                    RunSaveImageEstys(listData, pathSave);
                    while (pageEsty <= Etsy_Controller.pageTotal())
                    {
                        LogStatusLable("Running Get HTML");
                        LogStatusRichTetxbox(Color.BlueViolet, "Running Get HTML");

                        if (regexSection_Id == "")
                        {
                            listData = Etsy_Controller.GetListUrls_Etsy(regexNameShop, pageEsty * 36, idShop);
                        }
                        else
                        {
                            listData = Etsy_Controller.GetListUrls_Etsy_Section_id(regexNameShop, pageEsty * 36, idShop, regexSection_Id);
                        }

                        LogStatusRichTetxbox(Color.BlueViolet, "Get HTML Done ----->");

                        RunSaveImageEstys(listData, pathSave);
                    }
                    Etsy_Controller.resetCountItems();
                    LogStatusLable("Download xong roi!");
                }
                catch (Exception ex)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.AppendText(ex.Message + "\n");
                    }));
                }
            }
        }
        public void RunSaveImageEstys(List<Variable_Data_Image_GetHTML> listData,string pathSave)
        {
            pageEsty++;
            
            string pathExcel = pathSave + "\\DataExcel.xlsx";
            pathSave = DownloadHelper.CreateFolder(pathSave, "page - "+ pageEsty);
            string descriptions = "";
            string pathImages = "";
            foreach (var item in listData)
            {
                dem++;
                TimeSpan myDateResult = DateTime.Now.TimeOfDay;
                string timeSpan_tostring = myDateResult.Ticks.ToString();
                LogStatusLable("Running download index: " + dem);

                try
                {
                    string path_ = pathSave + $"\\{timeSpan_tostring}.png";
                    //download image
                    DownloadHelper.DownloadImage(item.url, path_);

                    //log status
                    LogStatusRichTetxbox(Color.Blue, "save done -----> : " + timeSpan_tostring + ".png");
                    string[] itemTittles = item.tittle.Split(' ');
                    string itemTittle = "";
                    foreach (var tittle in itemTittles)
                    {
                        if((itemTittle+ tittle).Length < 82)
                        {
                            itemTittle += tittle +" ";
                        }
                    }
                    itemTittle += DownloadHelper.GenerateRandomSKU(6);
                    descriptions += itemTittle + "\n";
                    pathImages += path_ + "\n";
                    SaveExcelData(pathExcel, itemTittle, path_);
                    //log status
                    LogStatusRichTetxbox(Color.Green, "--------SaveExcelData ------>: ");
                }
                catch (Exception ex)
                {
                    LogStatusRichTetxbox(Color.Red, ex.Message);
                }
            }
            LogStatusRichTetxbox(Color.Green, $"<-------- SAVE PAGE {pageEsty} DONE------>: ");
            DownloadHelper.SaveText(pathSave + "\\descriptions.txt", descriptions);
            DownloadHelper.SaveText(pathSave + "\\pathImages.txt", pathImages);
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeRadioWebsite = cbbType.SelectedValue.ToString();
        }
        public void LogStatusRichTetxbox(Color color , string message)
        {
            richTextBox1.Invoke(new MethodInvoker(() =>
            {
                richTextBox1.SelectionColor = color;
                richTextBox1.AppendText(message + "\n");
            }));
            
        }
        public void LogStatusLable(string message)
        {
            txtSlDownloadDone.Invoke(new MethodInvoker(() =>
            {
                txtSlDownloadDone.Text = message;
            }));

        }
        public void RunDownload_Etsy()
        {
            string regexNameShop = RegexShopName_Etsy();
            string regexSection_Id = RegexSection_id_Etsy();
            if (regexNameShop != "")
            {
                try
                {
                    string idShop = Etsy_Controller.Get_ID_shop_Etsy(regexNameShop);
                    if (idShop == string.Empty || idShop == "")
                    {
                        LogStatusLable("Get id shop error");
                        return;
                    }
                    LogStatusLable("Running Get HTML");
                    LogStatusRichTetxbox(Color.BlueViolet, txtSlDownloadDone.Text);

                    List<Variable_Data_Image_GetHTML> listData = new List<Variable_Data_Image_GetHTML>();
                    if (regexSection_Id == "")
                    {
                        listData = Etsy_Controller.GetListUrls_Etsy(regexNameShop, 0, idShop);
                    }
                    else
                    {
                        listData = Etsy_Controller.GetListUrls_Etsy_Section_id(regexNameShop, 0, idShop, regexSection_Id);
                    }

                    LogStatusRichTetxbox(Color.BlueViolet, "Get HTML Done -----> ");

                    string pathSave = txtPathSave.Text.Trim();

                    //khoi tao foler  type website download
                    pathSave = DownloadHelper.CreateFolder(pathSave, TypeRadioWebsite);

                    //khoi tao foler  ten shop
                    pathSave = DownloadHelper.CreateFolder(pathSave, regexNameShop);

                    RunSaveImageEstys(listData, pathSave);
                }
                catch (Exception ex)
                {
                    LogStatusRichTetxbox(Color.Red, ex.Message);
                }
            }
        }
        public void SaveExcelData(string pathExcel,string tittle,string pathImage)
        {
            string nameSheet = txtNameSheet.Text.Trim();
            string product = txtProduct.Text.Trim();
            string price = txtPrice.Text.Trim();
            string pathZip = txtPathZip.Text.Trim();
            DownloadHelper.WriteToExcel(pathExcel,nameSheet,tittle,product,pathImage,price,pathZip);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPathSave.Text = fbd.SelectedPath;
                }
            }
        }
        public void SetEnableButtonDownload(bool enable)
        {
            btnDownload.Invoke(new MethodInvoker(() =>
            {
                btnDownload.Enabled = enable;
                btnDownload1Page.Enabled = enable;
            }));

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }
    }
}
