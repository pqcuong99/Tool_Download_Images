using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tool_Download_Image_Inspireuplift.Controller
{
    public class DownloadHelper
    {
        public static bool DownloadImage(string url, string pathSave)
        {
            try
            {
                // Get the response from the URL.
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), pathSave);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool SaveText(string pathSave , string data)
        {
            try
            {
                if (!File.Exists(pathSave))
                {
                    // Nếu không tồn tại, tạo tập tin mới
                    using (StreamWriter sw = File.CreateText(pathSave))
                    {
                        sw.Write(data);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(pathSave))
                    {
                        sw.Write(data);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static string CreateFolder(string pathSave, string nameFolder)
        {
            try
            {
                pathSave = pathSave + "\\"+ nameFolder;

                if (!Directory.Exists(pathSave))
                {
                    // Create the folder.
                    Directory.CreateDirectory(pathSave);
                }

                return pathSave;
            }
            catch (Exception e)
            {
                return pathSave;
            }
        }
        public static void WriteToExcel(string pathExcel,string sheetName,string tittle,string product,string pathImage,string price,string pathZip)
        {
            string excelFilePath = pathExcel;   // "D:\\path\\to\\your\\excelFile.xlsx"; // Đường dẫn tới tệp Excel

            // Kiểm tra xem tệp Excel đã tồn tại hay không
            FileInfo excelFile = new FileInfo(excelFilePath);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = null;

                // Kiểm tra xem sheet đã tồn tại hay không
                if (package.Workbook.Worksheets[sheetName] != null)
                {
                    worksheet = package.Workbook.Worksheets[sheetName];
                }
                else
                {
                    // Tạo sheet mới nếu không tồn tại
                    worksheet = package.Workbook.Worksheets.Add(sheetName);

                    // Đặt tiêu đề cho các cột
                    worksheet.Cells[1, 1].Value = "uid";
                    worksheet.Cells[1, 2].Value = "tittle";
                    worksheet.Cells[1, 3].Value = "product_category";
                    worksheet.Cells[1, 4].Value = "features";
                    worksheet.Cells[1, 5].Value = "path_image";
                    worksheet.Cells[1, 6].Value = "price";
                    worksheet.Cells[1, 7].Value = "upload_file";
                }

                // Tìm dòng trống tiếp theo để ghi dữ liệu
                int row = worksheet.Dimension.End.Row + 1;

                // Ghi dữ liệu vào các ô tương ứng
                worksheet.Cells[row, 1].Value = ""; // uid
                worksheet.Cells[row, 2].Value = tittle; // title
                worksheet.Cells[row, 3].Value = product; // product_category
                worksheet.Cells[row, 4].Value = ""; // features
                worksheet.Cells[row, 5].Value = pathImage; // path_image
                worksheet.Cells[row, 6].Value = price; // price
                worksheet.Cells[row, 7].Value = pathZip; // upload_file

                // Lưu các thay đổi vào tệp Excel
                package.Save();
            }
        }
        public static string ReadOrCreateFile(string filePath)
        {
            try
            {
                // Đọc dữ liệu từ tệp tin nếu tồn tại
                return  File.ReadAllText(filePath);
            }
            catch (FileNotFoundException)
            {
                // Ghi dữ liệu vào tệp tin mới
                File.WriteAllText(filePath, "");
                return "";

            }
        }
        public static void WriteFileDataForm(string filePath, string newData)
        {
            try
            {
                // Xóa nội dung của tệp tin cũ
                File.WriteAllText(filePath, string.Empty);

                // Ghi dữ liệu mới vào tệp tin
                File.WriteAllText(filePath, newData);

            }
            catch (Exception ex)
            {
            }
        }
        public static string GenerateRandomSKU(int length)
        {
            // Ký tự cho phép trong mã SKLU
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Tạo đối tượng Random
            Random rand = new Random();

            // Tạo mã SKLU ngẫu nhiên bằng cách chọn ngẫu nhiên ký tự từ allowedChars
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rand.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
