﻿// <auto-generated />
using MarketingCenterData.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketingCenterData.Migrations
{
    [DbContext(typeof(McdbContext))]
    [Migration("20230929172829_CreateContentPublish")]
    partial class CreateContentPublish
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarketingCenterData.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnDisplay")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("MarketingCenterData.ContentPublish", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ContentPublishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geomarket")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InteriorSubcategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.Property<string>("audio_animation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_autostart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_hide_info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_loop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audio_volume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_featured_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_featured_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_use_discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dashboard_notifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enable_mls_search")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_1_homepage_only")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_4_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_5_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_6_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_7_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file_8_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("headline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("high_priority_notification_text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home_discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home_featured_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home_featured_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home_use_discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img_align")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img_span")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img_wrap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_title_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_title_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_title_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_url_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_url_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_url_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meta_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("no_new_comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("package_template")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_category_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_interior_subcategory_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_subcategory_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("post_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pretty_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publish_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("search_tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("show_comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("show_item_in_mobile1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("show_item_in_mobile2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("show_item_in_mobile3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("show_item_in_mobile4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("static_document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teaser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text_markup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("unlocked")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("use_discontinue_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vid_caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video_autostart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video_height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video_loop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video_width")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("visible_to_managers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("InteriorSubcategoryId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("ContentPublish", (string)null);
                });

            modelBuilder.Entity("MarketingCenterData.InteriorSubCategory", b =>
                {
                    b.Property<int>("InteriorsubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InteriorsubcategoryId"));

                    b.Property<string>("CatLandingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatLandingDescriptionMarkup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionMarkup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExternalUrlActive")
                        .HasColumnType("bit");

                    b.Property<byte[]>("FileOrig")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnDisplay")
                        .HasColumnType("bit");

                    b.Property<string>("PrettyUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Static")
                        .HasColumnType("bit");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.HasKey("InteriorsubcategoryId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("InteriorSubCategory", (string)null);
                });

            modelBuilder.Entity("MarketingCenterData.Subcategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubcategoryId"));

                    b.Property<string>("CatLandingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatLandingDescriptionMarkup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionMarkup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExternalUrlActive")
                        .HasColumnType("bit");

                    b.Property<byte[]>("FileOrig")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnDisplay")
                        .HasColumnType("bit");

                    b.Property<string>("PrettyUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Static")
                        .HasColumnType("bit");

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory", (string)null);
                });

            modelBuilder.Entity("MarketingCenterData.ContentPublish", b =>
                {
                    b.HasOne("MarketingCenterData.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingCenterData.InteriorSubCategory", "InteriorSubcategory")
                        .WithMany()
                        .HasForeignKey("InteriorSubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingCenterData.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("InteriorSubcategory");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("MarketingCenterData.InteriorSubCategory", b =>
                {
                    b.HasOne("MarketingCenterData.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("MarketingCenterData.Subcategory", b =>
                {
                    b.HasOne("MarketingCenterData.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}