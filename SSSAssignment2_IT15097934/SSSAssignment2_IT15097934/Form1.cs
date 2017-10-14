using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using System.Security.Cryptography;



namespace SSSAssignment2_IT15097934
{

    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>

   
    ///////////////////////////////////////////////////////////////
    public partial class frm_encDec : Form
    {
        public frm_encDec()
        {
            InitializeComponent();
            desobj = RSA.Create() ;

        }


        AsymmetricAlgorithm desobj;
       RsaKeyParameters GpublicKey;
       RsaKeyParameters GprivateKey;


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void btn_generate_Click(object sender, EventArgs e)
        {
            //Generating the key pair
            RsaKeyPairGenerator keypair = new RsaKeyPairGenerator();
            keypair.Init(new KeyGenerationParameters(new SecureRandom(),2048));
            AsymmetricCipherKeyPair cipherkp = keypair.GenerateKeyPair();
            RsaKeyParameters privateKey = (RsaKeyParameters)cipherkp.Private;
            RsaKeyParameters publicKey = (RsaKeyParameters)cipherkp.Public;
            
            GpublicKey = publicKey;
            GprivateKey = privateKey;
            if (publicKey != null)
            {
                MessageBox.Show("Key Pair is generated successfully");
            }
        }


        private void radioB(object sender, EventArgs e)
        {

        }

        public void btn_enc_Ok_Click(object sender, EventArgs e)
        {
            
            bool isChecked_enc = rb_enc_pri.Checked;
            //Encryption using private key
            if (isChecked_enc)
            {

                IAsymmetricBlockCipher cipher = new OaepEncoding(new RsaEngine());
                cipher.Init(true, GprivateKey);
                // byte[] ciphertext = System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);
                byte[] plaintext= System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);

                byte[] ciphertext = cipher.ProcessBlock(plaintext,0,plaintext.Length);

                string result = Encoding.UTF8.GetString(ciphertext);
                txt_enc_output.Text = result;

                //txt_enc_output.Text = System.Text.Encoding.UTF8.GetString(ciphertext);


            }
            //encryption using public key
            else
            {


                IAsymmetricBlockCipher cipher = new OaepEncoding(new RsaEngine());
                cipher.Init(true, GpublicKey);
                // byte[] ciphertext = System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);
                byte[] plaintext = System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);

                byte[] ciphertext = cipher.ProcessBlock(plaintext, 0, plaintext.Length);

                string result = Encoding.UTF8.GetString(ciphertext);
                txt_enc_output.Text = result;


            }

        }

        public void btn_dec_OK_Click(object sender, EventArgs e)
        {
            bool isChecked_dec = rb_dec_pri.Checked;
            bool isChecked_enc = rb_enc_pri.Checked;
            bool isChecked_enc_pub = rb_enc_pub.Checked;
            bool isChecked_dec_Pub = rb_dec_pub.Checked;

            if (isChecked_enc)
            {
                if (isChecked_enc && isChecked_dec)
                {
                    MessageBox.Show("You encrypted using private key. Please select public key");
                }
                else if (isChecked_dec_Pub && isChecked_enc_pub)
                {
                    MessageBox.Show("You encrypted using public key. Please select private Key");

                }

                else if ( isChecked_dec_Pub)
                {



                    IAsymmetricBlockCipher cipherdec = new OaepEncoding(new RsaEngine());
                    cipherdec.Init(false, GpublicKey);
                    //byte[] ciphertext = System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);
                    byte[] plaintext = Encoding.UTF8.GetBytes(txt_dec_writeText.Text);

                    byte[] ciphertext = cipherdec.ProcessBlock(plaintext, 0, plaintext.Length);

                    string result = Encoding.UTF8.GetString(ciphertext);
                    txt_dec_output.Text = result;
                }



                else
                {


                    IAsymmetricBlockCipher cipherdec = new OaepEncoding(new RsaEngine());
                    cipherdec.Init(false, GprivateKey);
                    // byte[] ciphertext = System.Text.Encoding.UTF8.GetBytes(txt_enc_writeText.Text);
                    byte[] plaintext = Encoding.UTF8.GetBytes(txt_dec_writeText.Text);
                    
                    byte[] ciphertext = cipherdec.ProcessBlock(plaintext, 0, plaintext.Length);

                    string result = Encoding.UTF8.GetString(ciphertext);
                    txt_dec_output.Text = result;



                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
