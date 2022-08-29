using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace padel_app_21
{
    public class Archivo
    {
        //FUNCION GUARDAR ARCHIVO.DAT
        public static bool Guardar(string filename, Sistema sistema)
        {
            FileStream file = null;
            bool result = false;
            try
            {
                file = new FileStream(filename, FileMode.Create);
                BinaryFormatter formateador = new BinaryFormatter();
                formateador.Serialize(file, sistema);
                file.Close();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
            return result;
        }

        //FUNCION GUARDAR COMO JPG
        public static bool Guardar(string filename, Panel panel)
        {
            FileStream file = null;
            Bitmap bm = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bm,new Rectangle(0, 0, panel.Width, panel.Height));
            bool result = false;
            try
            {
                file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                bm.Save(file, System.Drawing.Imaging.ImageFormat.Bmp);
                file.Close();
                bm.Dispose();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
            return result;
        }

        //FUNCION ABRIR ARCHIVO.DAT
        public static Sistema Abrir(string filename)
        {
            FileStream file = null;
            Sistema sistema;
            try
            {
                file = new FileStream(filename, FileMode.Open);
                BinaryFormatter formateador = new BinaryFormatter();
                sistema = formateador.Deserialize(file) as Sistema;
            }
            catch(Exception ex)
            {
                sistema = new Sistema();
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
            return sistema;
        }
    }//FIN Archivo
}//FIN NAMESPACE
