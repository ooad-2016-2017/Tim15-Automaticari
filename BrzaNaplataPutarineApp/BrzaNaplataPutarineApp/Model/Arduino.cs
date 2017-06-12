
using BrzaNaplataPutarineApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;

namespace BrzaNaplataPutarineApp.Model
{
    public class Arduino
    {
        SerialDevice uredjaj;
        public static List<SerijskiUredjajIIme> serijskiUredjaji;
        public String udaljenost;

        public SerialDevice Uredjaj
        {
            get
            {
                return uredjaj;
            }

            set
            {
                if(value != uredjaj)
                {
                    uredjaj = value;
                }
            }
        }

        public Arduino(SerialDevice uredjaj)
        {
            this.Uredjaj = uredjaj;
            udaljenost = "Nije procitano";
            uredjaj.BaudRate = 9600;
            uredjaj.DataBits = 8;
            uredjaj.Parity = SerialParity.None;
            uredjaj.Handshake = SerialHandshake.None;
            uredjaj.StopBits = SerialStopBitCount.One;
            uredjaj.ReadTimeout = TimeSpan.FromMilliseconds(1000);
            uredjaj.WriteTimeout = TimeSpan.FromMilliseconds(1000);
        }
        public async static Task skenirajPortove()
        {
            serijskiUredjaji = new List<SerijskiUredjajIIme>();
            var tmp = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());
            var infos = tmp.ToList();
            foreach (var i in infos)
            {
                SerialDevice dev = await SerialDevice.FromIdAsync(i.Id);
                serijskiUredjaji.Add(new SerijskiUredjajIIme(dev, i.Name));
            }
        }

        public async Task dajUdaljenost()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("1");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if (primljeno >= (uint)0)
                udaljenost = dr.ReadString(primljeno);

        }
       
    }
}