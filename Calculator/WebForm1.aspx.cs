using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        Button btnToplama = new Button();
        Button btnCarpma = new Button();
        Button btnBolme = new Button();
        Button btnCikarma = new Button();
        Table tbl = new Table();
        TextBox txtBox1 = new TextBox();
        TextBox txtBox2 = new TextBox();
        TextBox txtBox3 = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnToplama.Text = "+";
            btnToplama.ID = "1";
            btnToplama.Click += yaz;
            btnToplama.Click += islem;
            
         //   btnToplama.Click -= islem;
            btnCikarma.Text = "-";
            btnCikarma.ID = "2";
            btnCikarma.Click += islem;
            btnCarpma.Text = "*";
            btnCarpma.ID = "3";
            btnCikarma.Click += islem;
            btnBolme.Text = "/";
            btnBolme.ID = "4";
            btnBolme.Click += bolme;

            form1.Controls.Add(new LiteralControl("<h1> * Calculator *</h1>"));
            form1.Controls.Add(txtBox1);
            form1.Controls.Add(new LiteralControl("<br>"));
            form1.Controls.Add(txtBox2);
            form1.Controls.Add(new LiteralControl("<br>"));
            form1.Controls.Add(txtBox3);
            form1.Controls.Add(new LiteralControl("<br>"));

            form1.Controls.Add(btnToplama);
            form1.Controls.Add(new LiteralControl(" "));
            form1.Controls.Add(btnCikarma);
            form1.Controls.Add(new LiteralControl(" "));
            form1.Controls.Add(btnCarpma);
            form1.Controls.Add(new LiteralControl(" "));
            form1.Controls.Add(btnBolme);
                  
        }


        void islem(object obj, EventArgs e)
        {    
            
            Button btDurum = (Button)obj;
            int tbox1 = int.Parse(txtBox1.Text);
            int tbox2 = int.Parse(txtBox2.Text);
            int sonuc = 0;
            switch (int.Parse(btDurum.ID))
            {
                case 1:                  
                        sonuc = tbox1 + tbox2;
                        break;
                case 2:
                        sonuc = tbox1 - tbox2;                       
                        break;
                case 3:
                    sonuc = tbox1 * tbox2;
                    break;

            }
            txtBox3.Text = sonuc.ToString();
        }

        void bolme(object obj, EventArgs e)
        {
            int tbox1 = int.Parse(txtBox1.Text);
            int tbox2 = int.Parse(txtBox2.Text);
            txtBox3.Text = (tbox1*1.0/tbox2).ToString();
        }

        void yaz(object obj, EventArgs e)
        {
          form1.Controls.Add(new LiteralControl("Topladım."));
        }

    }
}