using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundDominator_v2
{
    internal class Cambiador
    {
        [DllImport("user32.dll")]
        public static extern Int32 SystemParametersInfo(
                       UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        public static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        public static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        public static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        public const int Centered = 0;
        public const int Tiled = 1;
        public const int Stretched = 2;

        public static void cambiarFondo(String nRuta)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, nRuta,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
        public static void Estilos(int estilo)
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            switch (estilo)
            {
                case 2:
                    key.SetValue(@"WallpaperStyle", 2.ToString());

                    key.SetValue(@"TileWallpaper", 0.ToString());

                    break;

                case 1:
                    key.SetValue(@"WallpaperStyle", 1.ToString());

                    key.SetValue(@"TileWallpaper", 0.ToString());

                    break;

                default:
                case 0:
                    key.SetValue(@"WallpaperStyle", 1.ToString());

                    key.SetValue(@"TileWallpaper", 1.ToString());

                    break;

            }
        }
    }
}
