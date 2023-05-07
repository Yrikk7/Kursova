using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Vector
        {
            private double x;
            public double Xer
            {
                get
                {
                    return x;
                }
                set
                {
                    if(value == Convert.ToDouble("0"))
                     {
                        value = x;
                    }  
                    else
                    {
                        x = value;
                    }
                }
            }
            private double y;
            public double Yer
            {
                get
                {
                    return y;
                }
                set
                {
                    if (value == Convert.ToDouble("0"))
                    {
                        value = y;
                    }
                    else
                    {
                        y = value;
                    }
                }
             }
            private double z;
            public double Zer
            {
                get
                {
                    return z;
                }
                set
                {
                    if (value == Convert.ToDouble("0"))
                    {
                        value = z;
                    }
                    else
                    {
                        z = value;
                    }
                }
            }
            public double ui;            
            public double jok;
            public Vector(double r , double u, double t)
            {
                this.x = r;
                this.y = u;
                this.z = t;
            }
            public Vector()
            {                
            }
            public Vector Add(Vector t)
            {
                Vector fyl = new Vector();
                fyl.x = this.x + t.x;
                fyl.y = this.y + t.y;
                fyl.z = this.z + t.z;
                return fyl;
            }
            public Vector Vid(Vector s)
            {
                Vector fyl = new Vector();
                fyl.x = this.x - s.x;
                fyl.y = this.y - s.y;
                fyl.z = this.z - s.z;
                return fyl;
            }
            public Vector Skulur(Vector oy)
            {
                Vector fyl = new Vector();
                fyl.x = this.x * oy.x;
                fyl.y = this.y * oy.y;
                fyl.z = this.z * oy.z;
                fyl.ui = fyl.x + fyl.y + fyl.z;              
                return fyl;
            }
            public Vector Mnozh(double gog)
            {
                Vector fyl = new Vector();
                fyl.x = this.x * gog;
                fyl.y = this.y * gog;
                fyl.z = this.z * gog;
                return fyl;
            }
            public Vector Modul()
            {
                Vector fyl = new Vector();
                fyl.x = Math.Pow(this.x, 2);
                fyl.y = Math.Pow(this.y, 2);
                fyl.z = Math.Pow(this.z, 2);
                fyl.jok = Math.Pow((fyl.x + fyl.y + fyl.z),0.5);                
                return fyl;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            widmas.Text = postxa.Text = postya.Text = postza.Text = postxb.Text = postyb.Text = postzb.Text = "";
            xast.Text = yast.Text = zast.Text = xbst.Text = ybst.Text = zbst.Text = df.Text = gh.Text = jo.Text = kik.Text = "";
            gig.Text = hih.Text = nm.Text = kl.Text = vn.Text = label77.Text = label75.Text = label73.Text = label96.Text = label94.Text = "";
            label92.Text = label88.Text = label86.Text = label84.Text = label104.Text = label129.Text = "";
            label127.Text = label125.Text = label121.Text = label119.Text = label117.Text = label138.Text = label136.Text = label134.Text = "";
            label146.Text = label144.Text = label142.Text = label171.Text = label169.Text = label167.Text = label163.Text = label161.Text = "";
            label159.Text = label176.Text = label177.Text = "";

            xa.Text = ya.Text = za.Text = xb.Text = yb.Text = zb.Text = ret.Text = set.Text = get.Text = het.Text = zet.Text = qet.Text = "0";
            textBox6.Text = textBox5.Text = textBox4.Text = textBox3.Text = textBox2.Text = textBox1.Text = textBox12.Text = textBox11.Text = "0";
            textBox10.Text = textBox9.Text = textBox8.Text = textBox7.Text = textBox18.Text = textBox17.Text = textBox16.Text = textBox19.Text = "0";
            textBox15.Text = textBox14.Text = textBox13.Text = textBox25.Text = textBox24.Text = textBox23.Text = textBox22.Text = "0";
            textBox21.Text = textBox20.Text = "0";
            tnOK.Text = "Відсортувати";
            ttOK.Text = "Показ векторів";
            frOK.Text = "Додати вектори";
            erOK.Text = "Вирахувати вектори";
            button2.Text = "Помножити вектори";
            button3.Text = "Помножити вектор А на число";
            button4.Text = "Помножити вектор Б на число";
            button5.Text = "Знайти модуль";           
        }

        private void ttOK_Click(object sender, EventArgs e)
        {
            double sd = Convert.ToDouble(xa.Text);
            double sgj = Convert.ToDouble(ya.Text);
            double plo = Convert.ToDouble(za.Text);
            double ghj = Convert.ToDouble(xb.Text);
            double mnv = Convert.ToDouble(yb.Text);
            double sdjk = Convert.ToDouble(zb.Text);
            if (Convert.ToString(sd) != "0" && Convert.ToString(sgj) != "0" && Convert.ToString(plo) != "0" && Convert.ToString(ghj) != "0"
                && Convert.ToString(mnv) != "0"&& Convert.ToString(sdjk) != "0")
            {
                Vector l = new Vector(sd, sgj, plo);
                Vector k = new Vector(ghj, mnv, sdjk);
                postxa.Text = xast.Text = kik.Text = label96.Text = label129.Text = label171.Text = Convert.ToString(l.Xer);
                postya.Text = yast.Text = gig.Text = label94.Text = label127.Text = label169.Text = Convert.ToString(l.Yer);
                postza.Text = zast.Text = hih.Text = label92.Text = label125.Text = label167.Text = Convert.ToString(l.Zer);
                postxb.Text = xbst.Text = nm.Text = label88.Text = label121.Text = label163.Text = Convert.ToString(k.Xer);
                postyb.Text = ybst.Text = kl.Text = label86.Text = label119.Text = label161.Text = Convert.ToString(k.Yer);
                postzb.Text = zbst.Text = vn.Text = label84.Text = label117.Text = label159.Text = Convert.ToString(k.Zer);
            }
            

        }

        private void xa_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {                
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (xa.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (ya.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void za_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (za.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void xb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (xb.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void yb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (yb.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void zb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (zb.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ttOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void frOK_Click(object sender, EventArgs e)
        {
            double fop = Convert.ToDouble(xast.Text);
            double lop = Convert.ToDouble(yast.Text);
            double mop = Convert.ToDouble(zast.Text);
            double fok = Convert.ToDouble(xbst.Text);
            double lok = Convert.ToDouble(ybst.Text);
            double mok = Convert.ToDouble(zbst.Text);
            Vector ll = new Vector(fop, lop, mop);
            Vector kk = new Vector(fok, lok, mok);
            ll.Xer = Convert.ToDouble(ret.Text);            
            ll.Yer = Convert.ToDouble(set.Text);
            ll.Zer = Convert.ToDouble(get.Text);
            kk.Xer = Convert.ToDouble(het.Text);
            kk.Yer = Convert.ToDouble(zet.Text);
            kk.Zer = Convert.ToDouble(qet.Text);
            xast.Text = Convert.ToString(ll.Xer);
            yast.Text = Convert.ToString(ll.Yer);
            zast.Text = Convert.ToString(ll.Zer);
            xbst.Text = Convert.ToString(kk.Xer);
            ybst.Text = Convert.ToString(kk.Yer);
            zbst.Text = Convert.ToString(kk.Zer);
            Vector lk = new Vector();
            lk = ll.Add(kk);
            df.Text = Convert.ToString(lk.Xer);
            gh.Text = Convert.ToString(lk.Yer);
            jo.Text = Convert.ToString(lk.Zer);
        }

        private void ret_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (ret.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void set_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (set.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void get_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (get.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void het_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (het.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void zet_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (zet.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void qet_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (qet.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    frOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void erOK_Click(object sender, EventArgs e)
        {
            double vb = Convert.ToDouble(kik.Text);
            double gf = Convert.ToDouble(gig.Text);
            double hj = Convert.ToDouble(hih.Text);
            double mc = Convert.ToDouble(nm.Text);
            double mb = Convert.ToDouble(kl.Text);
            double ju = Convert.ToDouble(vn.Text);
            Vector ss = new Vector(vb, gf, hj);
            Vector mm = new Vector(mc, mb, ju);
            ss.Xer = Convert.ToDouble(textBox6.Text);
            ss.Yer = Convert.ToDouble(textBox5.Text);
            ss.Zer = Convert.ToDouble(textBox4.Text);
            mm.Xer = Convert.ToDouble(textBox3.Text);
            mm.Yer = Convert.ToDouble(textBox2.Text);
            mm.Zer = Convert.ToDouble(textBox1.Text);
            kik.Text = Convert.ToString(ss.Xer);
            gig.Text = Convert.ToString(ss.Yer);
            hih.Text = Convert.ToString(ss.Zer);
            nm.Text = Convert.ToString(mm.Xer);
            kl.Text = Convert.ToString(mm.Yer);
            vn.Text = Convert.ToString(mm.Zer);
            Vector ls = new Vector();
            ls = ss.Vid(mm);
            label77.Text = Convert.ToString(ls.Xer);
            label75.Text = Convert.ToString(ls.Yer);
            label73.Text = Convert.ToString(ls.Zer);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox6.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox5.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox4.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    erOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ho = Convert.ToDouble(label96.Text);
            double lo = Convert.ToDouble(label94.Text);
            double po = Convert.ToDouble(label92.Text);
            double op = Convert.ToDouble(label88.Text);
            double ol = Convert.ToDouble(label86.Text);
            double oh = Convert.ToDouble(label84.Text);
            Vector vlo = new Vector(ho, lo, po);
            Vector lpo = new Vector(op, ol, oh);
            vlo.Xer = Convert.ToDouble(textBox12.Text);
            vlo.Yer = Convert.ToDouble(textBox11.Text);
            vlo.Zer = Convert.ToDouble(textBox10.Text);
            lpo.Xer = Convert.ToDouble(textBox9.Text);
            lpo.Yer = Convert.ToDouble(textBox8.Text);
            lpo.Zer = Convert.ToDouble(textBox7.Text);
            label96.Text = Convert.ToString(vlo.Xer);
            label94.Text = Convert.ToString(vlo.Yer);
            label92.Text = Convert.ToString(vlo.Zer);
            label88.Text = Convert.ToString(lpo.Xer);
            label86.Text = Convert.ToString(lpo.Yer);
            label84.Text = Convert.ToString(lpo.Zer);
            Vector kk = new Vector();
            kk = vlo.Skulur(lpo);            
            label104.Text = Convert.ToString(kk.ui);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox12.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox11.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox10.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox9.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox8.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox7.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ag = Convert.ToDouble(label129.Text);
            double ad = Convert.ToDouble(label127.Text);
            double ax = Convert.ToDouble(label125.Text);
            double ak = Convert.ToDouble(textBox19.Text);
            if (ak != 0)
            {
                Vector hj = new Vector(ag, ad, ax);
                hj.Xer = Convert.ToDouble(textBox18.Text);
                hj.Yer = Convert.ToDouble(textBox17.Text);
                hj.Zer = Convert.ToDouble(textBox16.Text);
                label129.Text = Convert.ToString(hj.Xer);
                label127.Text = Convert.ToString(hj.Yer);
                label125.Text = Convert.ToString(hj.Zer);
                Vector jh = new Vector();
                jh = hj.Mnozh(ak);
                label138.Text = Convert.ToString(jh.Xer);
                label136.Text = Convert.ToString(jh.Yer);
                label134.Text = Convert.ToString(jh.Zer);
            }
            else
            {
                Vector hj = new Vector(ag, ad, ax);
                hj.Xer = Convert.ToDouble(textBox18.Text);
                hj.Yer = Convert.ToDouble(textBox17.Text);
                hj.Zer = Convert.ToDouble(textBox16.Text);
                label138.Text = Convert.ToString(hj.Xer);
                label136.Text = Convert.ToString(hj.Yer);
                label134.Text = Convert.ToString(hj.Zer);                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double gj = Convert.ToDouble(label121.Text);
            double qw = Convert.ToDouble(label119.Text);
            double qe = Convert.ToDouble(label117.Text);
            double ak = Convert.ToDouble(textBox19.Text);
            if (ak != 0)
            {
                Vector ml = new Vector(gj, qw, qe);
                ml.Xer = Convert.ToDouble(textBox15.Text);
                ml.Yer = Convert.ToDouble(textBox14.Text);
                ml.Zer = Convert.ToDouble(textBox13.Text);
                label121.Text = Convert.ToString(ml.Xer);
                label119.Text = Convert.ToString(ml.Yer);
                label117.Text = Convert.ToString(ml.Zer);
                Vector pq = new Vector();
                pq = ml.Mnozh(ak);
                label146.Text = Convert.ToString(pq.Xer);
                label144.Text = Convert.ToString(pq.Yer);
                label142.Text = Convert.ToString(pq.Zer);
            }
            else
            {
                Vector ml = new Vector(gj, qw, qe);
                ml.Xer = Convert.ToDouble(textBox15.Text);
                ml.Yer = Convert.ToDouble(textBox14.Text);
                ml.Zer = Convert.ToDouble(textBox13.Text);
                label146.Text = Convert.ToString(ml.Xer);
                label144.Text = Convert.ToString(ml.Yer);
                label142.Text = Convert.ToString(ml.Zer);                
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox18.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button3.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox17.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button3.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox16.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button3.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox19.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button3.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox15.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button4.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
           
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox14.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button4.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox13.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button4.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double cv = Convert.ToDouble(label171.Text);
            double cvb = Convert.ToDouble(label169.Text);
            double cvu = Convert.ToDouble(label167.Text);
            double cvf = Convert.ToDouble(label163.Text);
            double cvq = Convert.ToDouble(label161.Text);
            double cvi = Convert.ToDouble(label159.Text);
            Vector klk = new Vector(cv, cvb, cvu);
            Vector jhj = new Vector(cvf, cvq, cvi);
            klk.Xer = Convert.ToDouble(textBox25.Text);
            klk.Yer = Convert.ToDouble(textBox24.Text);
            klk.Zer = Convert.ToDouble(textBox23.Text);
            jhj.Xer = Convert.ToDouble(textBox22.Text);
            jhj.Yer = Convert.ToDouble(textBox21.Text);
            jhj.Zer = Convert.ToDouble(textBox20.Text);
            label171.Text = Convert.ToString(klk.Xer);
            label169.Text = Convert.ToString(klk.Yer);
            label167.Text = Convert.ToString(klk.Zer);
            label163.Text = Convert.ToString(jhj.Xer);
            label161.Text = Convert.ToString(jhj.Yer);
            label159.Text = Convert.ToString(jhj.Zer);
            Vector khk = new Vector();
            khk = klk.Modul();
            label176.Text = Convert.ToString(khk.jok);
            Vector olx = new Vector();
            olx = jhj.Modul();
            label177.Text = Convert.ToString(olx.jok);
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox25.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox24.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox23.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox22.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox21.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox20.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button5.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void tnOK_Click(object sender, EventArgs e)
        {
            if (masmas.Text != "")
            {
                string input = masmas.Text;

                string[] rows = input.Split(';');
                int rowCount = rows.Length;

                double[][] vectors = new double[rowCount][];
                for (int i = 0; i < rowCount; i++)
                {
                    string[] columns = rows[i].Split(',');
                    int columnCount = columns.Length;

                    vectors[i] = new double[columnCount];
                    for (int j = 0; j < columnCount; j++)
                    {
                        vectors[i][j] = double.Parse(columns[j]);
                    }
                }

                Array.Sort(vectors, (a, b) => -a.Select(x => x * x).Sum().CompareTo(b.Select(x => x * x).Sum()));
                string output = string.Join("; ", vectors.Select(v => $"({string.Join(", ", v)})"));
                widmas.Text = output;
            }
            else
            {
                widmas.Text = "Ви не ввели масив";
            }
        }

        private void masmas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ';')
            {
                // цифра
                return;
            }
            if (e.KeyChar == ',')
            {
                // цифра
                return;
            }           
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    tnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
    
}
