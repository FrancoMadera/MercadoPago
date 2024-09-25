using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoPago.Client.Preference;
using MercadoPago.Resource.Preference;
using QRCoder;
using MercadoPago;
using MercadoPago.Config;
using static System.Net.Mime.MediaTypeNames;

namespace Formulario
{
        public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();
                GenerarQRCode();
            }

            private async void GenerarQRCode()
            {
            // Configura tu access token de Mercado Pago
                MercadoPagoConfig.AccessToken = "TEST-6080780208287699-082619-1389f4f48842c7717696641ecbdda35f-527880861";

                // Crear preferencia de pago
                PreferenceClient client = new PreferenceClient();
                PreferenceRequest request = new PreferenceRequest
                {
                    Items = new List<PreferenceItemRequest>
                    {
                        new PreferenceItemRequest
                        {
                            Title = "Producto de prueba",
                            Quantity = 3,
                            CurrencyId = "ARS",
                            UnitPrice = 5000m
                        }
                    }
                };

                Preference preference = await client.CreateAsync(request);

                // Generar el código QR
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(preference.InitPoint, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(4);

                // Mostrar el código QR en el PictureBox
                pictureBoxQR.Image = qrCodeImage;
            }
        }


    }
