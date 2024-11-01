using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Model.Instagram
{
    public class ResponseDataInstagram
    {
        public DataResponse data { get; set; }
        public Extensions extensions { get; set; }
        public string status { get; set; }
    }

    public class DataResponse
    {
        public Xdt_Api__V1__Feed__User_Timeline_Graphql_Connection xdt_api__v1__feed__user_timeline_graphql_connection { get; set; }
        public Xdt_Viewer xdt_viewer { get; set; }
    }

    public class Xdt_Api__V1__Feed__User_Timeline_Graphql_Connection
    {
        public Edge[] edges { get; set; }
        public Page_Info page_info { get; set; }
    }

    public class Page_Info
    {
        public string end_cursor { get; set; }
        public bool has_next_page { get; set; }
        public bool has_previous_page { get; set; }
        public object start_cursor { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
        public string cursor { get; set; }
    }

    public class Node
    {
        public string code { get; set; }
        public string pk { get; set; }
        public string id { get; set; }
        public object ad_id { get; set; }
        public object boosted_status { get; set; }
        public object boost_unavailable_identifier { get; set; }
        public object boost_unavailable_reason { get; set; }
        public Caption caption { get; set; }
        public bool caption_is_edited { get; set; }
        public object feed_demotion_control { get; set; }
        public object feed_recs_demotion_control { get; set; }
        public int taken_at { get; set; }
        public object inventory_source { get; set; }
        public Video_Versions[] video_versions { get; set; }
        public object is_dash_eligible { get; set; }
        public object number_of_qualities { get; set; }
        public object video_dash_manifest { get; set; }
        public Image_Versions2 image_versions2 { get; set; }
        public bool is_paid_partnership { get; set; }
        public object sponsor_tags { get; set; }
        public object affiliate_info { get; set; }
        public int original_height { get; set; }
        public int original_width { get; set; }
        public string organic_tracking_token { get; set; }
        public object link { get; set; }
        public object story_cta { get; set; }
        public User user { get; set; }
        public object group { get; set; }
        public Owner owner { get; set; }
        public object[] coauthor_producers { get; set; }
        public object[] invited_coauthor_producers { get; set; }
        public object follow_hashtag_info { get; set; }
        public object title { get; set; }
        public int comment_count { get; set; }
        public object comments_disabled { get; set; }
        public object commenting_disabled_for_viewer { get; set; }
        public bool like_and_view_counts_disabled { get; set; }
        public bool has_liked { get; set; }
        public object top_likers { get; set; }
        public object facepile_top_likers { get; set; }
        public int like_count { get; set; }
        public object preview { get; set; }
        public bool can_see_insights_as_brand { get; set; }
        public object social_context { get; set; }
        public object view_count { get; set; }
        public object can_reshare { get; set; }
        public bool can_viewer_reshare { get; set; }
        public bool ig_media_sharing_disabled { get; set; }
        public bool photo_of_you { get; set; }
        public string product_type { get; set; }
        public int media_type { get; set; }
        public object usertags { get; set; }
        public object media_overlay_info { get; set; }
        public object carousel_parent_id { get; set; }
        public int? carousel_media_count { get; set; }
        public Carousel_Media[] carousel_media { get; set; }
        public Location location { get; set; }
        public bool? has_audio { get; set; }
        public Clips_Metadata clips_metadata { get; set; }
        public object clips_attribution_info { get; set; }
        public object accessibility_caption { get; set; }
        public object audience { get; set; }
        public string display_uri { get; set; }
        public Media_Cropping_Info media_cropping_info { get; set; }
        public object thumbnails { get; set; }
        public object[] timeline_pinned_user_ids { get; set; }
        public object upcoming_event { get; set; }
        public object logging_info_token { get; set; }
        public object explore { get; set; }
        public object main_feed_carousel_starting_media_id { get; set; }
        public object is_seen { get; set; }
        public string open_carousel_submission_state { get; set; }
        public object previous_submitter { get; set; }
        public object all_previous_submitters { get; set; }
        public object headline { get; set; }
        public object comments { get; set; }
        public object saved_collection_ids { get; set; }
        public object has_viewer_saved { get; set; }
        public Sharing_Friction_Info sharing_friction_info { get; set; }
        public object media_level_comment_controls { get; set; }
        public string __typename { get; set; }
    }

    public class Caption
    {
        public object has_translation { get; set; }
        public int created_at { get; set; }
        public string pk { get; set; }
        public string text { get; set; }
    }

    public class Image_Versions2
    {
        public Candidate[] candidates { get; set; }
    }

    public class Candidate
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class User
    {
        public string pk { get; set; }
        public string username { get; set; }
        public string profile_pic_url { get; set; }
        public bool is_private { get; set; }
        public object is_embeds_disabled { get; set; }
        public bool is_unpublished { get; set; }
        public bool is_verified { get; set; }
        public object friendship_status { get; set; }
        public object latest_besties_reel_media { get; set; }
        public object latest_reel_media { get; set; }
        public object live_broadcast_visibility { get; set; }
        public object live_broadcast_id { get; set; }
        public object seen { get; set; }
        public object supervision_info { get; set; }
        public string id { get; set; }
        public Hd_Profile_Pic_Url_Info hd_profile_pic_url_info { get; set; }
        public string full_name { get; set; }
        public string __typename { get; set; }
    }

    public class Hd_Profile_Pic_Url_Info
    {
        public string url { get; set; }
    }

    public class Owner
    {
        public string pk { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
        public object friendship_status { get; set; }
        public object is_embeds_disabled { get; set; }
        public bool is_unpublished { get; set; }
        public bool is_verified { get; set; }
        public bool show_account_transparency_details { get; set; }
        public object supervision_info { get; set; }
        public object transparency_product { get; set; }
        public bool transparency_product_enabled { get; set; }
        public object transparency_label { get; set; }
        public string id { get; set; }
        public string __typename { get; set; }
        public bool is_private { get; set; }
    }

    public class Location
    {
        public long pk { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string name { get; set; }
        public object profile_pic_url { get; set; }
    }

    public class Clips_Metadata
    {
        public string audio_type { get; set; }
        public Achievements_Info achievements_info { get; set; }
        public object music_info { get; set; }
        public Original_Sound_Info original_sound_info { get; set; }
    }

    public class Achievements_Info
    {
        public bool show_achievements { get; set; }
    }

    public class Original_Sound_Info
    {
        public string original_audio_title { get; set; }
        public bool should_mute_audio { get; set; }
        public string audio_asset_id { get; set; }
        public Consumption_Info consumption_info { get; set; }
        public Ig_Artist ig_artist { get; set; }
        public bool is_explicit { get; set; }
    }

    public class Consumption_Info
    {
        public bool is_trending_in_clips { get; set; }
        public string should_mute_audio_reason { get; set; }
        public object should_mute_audio_reason_type { get; set; }
    }

    public class Ig_Artist
    {
        public string username { get; set; }
        public string id { get; set; }
    }

    public class Media_Cropping_Info
    {
        public Square_Crop square_crop { get; set; }
    }

    public class Square_Crop
    {
        public float crop_bottom { get; set; }
        public float crop_left { get; set; }
        public float crop_right { get; set; }
        public float crop_top { get; set; }
    }

    public class Sharing_Friction_Info
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
    }

    public class Video_Versions
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public int type { get; set; }
    }

    public class Carousel_Media
    {
        public string id { get; set; }
        public string pk { get; set; }
        public object accessibility_caption { get; set; }
        public object is_dash_eligible { get; set; }
        public object video_dash_manifest { get; set; }
        public int media_type { get; set; }
        public int original_height { get; set; }
        public int original_width { get; set; }
        public object inventory_source { get; set; }
        public object user { get; set; }
        public object usertags { get; set; }
        public Image_Versions21 image_versions2 { get; set; }
        public string carousel_parent_id { get; set; }
        public Sharing_Friction_Info1 sharing_friction_info { get; set; }
        public string preview { get; set; }
        public object organic_tracking_token { get; set; }
        public object saved_collection_ids { get; set; }
        public object has_viewer_saved { get; set; }
        public object video_versions { get; set; }
        public object media_overlay_info { get; set; }
        public string display_uri { get; set; }
        public object number_of_qualities { get; set; }
        public int taken_at { get; set; }
        public object previous_submitter { get; set; }
        public object link { get; set; }
        public object story_cta { get; set; }
        public object has_liked { get; set; }
        public object like_count { get; set; }
        public object logging_info_token { get; set; }
        public object owner { get; set; }
    }

    public class Image_Versions21
    {
        public Candidate1[] candidates { get; set; }
    }

    public class Candidate1
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Sharing_Friction_Info1
    {
        public object bloks_app_url { get; set; }
        public bool should_have_sharing_friction { get; set; }
    }

    public class Xdt_Viewer
    {
        public object user { get; set; }
    }

    public class Extensions
    {
        public bool is_final { get; set; }
    }

}
