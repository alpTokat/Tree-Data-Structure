using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class treeNode
        {
            public treeNode left;
            public int data;
            public treeNode right;
        }
        int sayac = 0;
        treeNode root;
        private void button1_Click(object sender, EventArgs e)
        {
            treeNode yeni = new treeNode();
            yeni.data = Convert.ToInt32(insertBox.Text);
            treeNode gecici = root;
            treeNode onceki = new treeNode();
            while (gecici != null)
            {
                onceki = gecici;
                if (gecici.data == yeni.data)
                {
                    MessageBox.Show("Aynı değer girilmişti,lütfen farkı değer giriniz.");
                    return;
                }
                if (yeni.data < gecici.data)
                {
                    gecici = gecici.left;
                }
                else
                {
                    gecici = gecici.right;
                }
                
            }
            if (root == null)
            {
                root = yeni;
            }
            else if (yeni.data < onceki.data) onceki.left = yeni;
            else onceki.right = yeni;
            label1.Text = "Eklenen Düğüm:" + yeni.data;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            treeNode gecici = root;
            if (gecici == null)
            {
                MessageBox.Show("Agaçta eleman bulunmamaktadır");
            }
            else
            {
                int sayac = 0;
                int deger = Convert.ToInt32(foundBox.Text);
                while (gecici.data != deger)
                {
                    if (deger < gecici.data)
                    {
                        sayac = sayac + 1;
                        gecici = gecici.left;
                    }
                    else
                    {
                        sayac = sayac + 1;
                        gecici = gecici.right;
                    }
                }
            }
            label3.Text = "Düğüm Düzeyi:" + sayac;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            showBox.Text = null;
            AgacYaz(root);
        }
        void AgacYaz(treeNode agac)
        {
            string konum = "";
            treeNode gecici = root;
            if (agac == null) return;
            while (gecici.data != agac.data)
            {
                if (agac.data<gecici.data)
                {
                    konum += " sol";
                    gecici = gecici.left;
                }
                else
                {
                    konum += " sağ";
                    gecici = gecici.right;
                }
            }
            if (agac.data == root.data)
            {
                showBox.Text += agac.data + "Kök" + "\r\n";
            }
            if (agac.data==gecici.data&&agac.data!=root.data)
            {
                showBox.Text += agac.data + konum + "\r\n";
            }
            AgacYaz(agac.left);
            AgacYaz(agac.right);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            sayac = 0;
            preorderBox.Text = null;
            PostorderBox.Text = null;
            InorderBox.Text = null;
            nodeBox.Text = null;
            heightBox.Text = null;
            leafBox.Text = null;
            Postorder(root);
            Preorder(root);
            Inorder(root);
            int yukseklik = height(root);
            heightBox.Text = Convert.ToString(yukseklik - 1);
        }
        void Postorder(treeNode agac)
        {
            if (agac == null) return;
            Postorder(agac.left);
            Postorder(agac.right);
            PostorderBox.Text += agac.data + ",";
        }
        void Preorder(treeNode agac)
        {
            if (agac == null) return;
            preorderBox.Text += agac.data + ",";

            Preorder(agac.left);
            Preorder(agac.right);
        }
        void Inorder(treeNode agac)
        {

            if (agac == null) return;
            Inorder(agac.left);
            sayac = sayac + 1;
            if (agac.left == null && agac.right == null)
            {
                leafBox.Text += agac.data + ">>";
            }
            InorderBox.Text += agac.data + ",";
            Inorder(agac.right);
            nodeBox.Text = sayac + " ";
        }
        int height(treeNode agac)
        {
            if (agac == null)
            {
                return 0;
            }
            return Math.Max(height(agac.left), height(agac.right)) + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(cancelBox.Text);
            Sil(root, deger);
        }
        treeNode Sil(treeNode agac, int deger)
        {
            treeNode gecici, gecici2;
            if (agac == null) return null;
            if (agac.data == deger)
            {
                if (agac.left == null && agac.right == null)
                {
                    return null;
                }
                else if (agac.left == null)
                {
                    gecici = agac.right;
                    agac = null;
                    return gecici;
                }
                else if (agac.right == null)
                {
                    gecici = agac.left;
                    agac = null;
                    return gecici;
                }
                else
                {
                    gecici = gecici2 = agac.right;
                    while (gecici.left != null)
                    {
                        gecici = gecici.left;
                    }
                    gecici.left = agac.left;
                    agac = null;
                    return gecici2;
                }
            }
            else if (agac.data < deger)
            {
                agac.right = Sil(agac.right, deger);
            }
            else
            {
                agac.left = Sil(agac.left, deger);
            }
            return agac;
        }
    }
}


