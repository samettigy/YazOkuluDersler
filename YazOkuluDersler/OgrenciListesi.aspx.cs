﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluDersler
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}