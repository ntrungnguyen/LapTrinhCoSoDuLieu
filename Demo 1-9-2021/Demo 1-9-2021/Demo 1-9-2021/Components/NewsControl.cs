﻿using Demo_1_9_2021.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo_1_9_2021.Components
{
    public partial class NewsControl : UserControl
    {
        public NewsControl()
        {
            InitializeComponent();
        }

        public void SetArticle(Article news)
        {
            lblTitle.Text = news.Title;
            lblDescription.Text = news.Description;
            lblPublisherDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            lBlDetails.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }

        private void NewsControl_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height + 1);
        }
    }
}