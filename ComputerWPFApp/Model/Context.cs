using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace ComputerWPFApp.Model
{
    partial class DatabaseComputerEntities
    {
        private static DatabaseComputerEntities context;
        public static DatabaseComputerEntities GetContext()
        {
            if (context == null) context = new DatabaseComputerEntities();
            return context;
        }
    }


    partial class Компьютер
    {
        public string proc
        {
            get
            {
                return $"{Процессор.Модель} Ядер:{Процессор.КолвоЯдер} Частота:{Процессор.Частота} ГГц";
            }
        }
        public string video
        {
            get
            {
                return $"{Видеокарта.Модель} {Видеокарта.ОбъемВидеопамяти} ГБ";
            }
        }
        public string ram
        {
            get
            {
                return $"{ТипОперативнойПамяти} {ОбъемОперативнойПамяти} ГБ";
            }
        }
        public string memory
        {
            get
            {
                return $"{ТипНакопителяДанных} {ОбъемНакопителя} ГБ";
            }
        }

        public BitmapSource Img
        {
            get
            {
                if (Изображение != null) try { return (BitmapSource)new ImageSourceConverter().ConvertFrom(Изображение); }
                    catch { return null; }
                return null;
            }
        }
    }
}
