using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public static class BizimEnumerable
    {
        public static IEnumerable<T> Filtrele<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            var index = 0;
            foreach (T obj in source)
            {
                if (predicate(obj, index))
                    yield return obj;
                index++;
            }
        }

        public static IEnumerable<T> Filtrele<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T obj in source)
            {
                if (predicate(obj))
                    yield return obj;
            }
        }

        public static IEnumerable<TResult> Sec<T, TResult>(this IEnumerable<T> source, Func<T, TResult> predicate)
        {
            foreach (T obj in source)
                yield return predicate(obj);
        }

        public static IEnumerable<T> Getir<T>(this IEnumerable<T> source, int number)
        {
            int counter = 0;
            foreach (T obj in source)
            {
                counter++;
                yield return obj;

                if (counter == number)
                    break;
            }
        }

        public static int Say<T>(this IEnumerable<T> source)
        {
            int toplam = 0;
            foreach (T obj in source)
            {
                toplam++;
            }
            return toplam;
        }

        public static int Say<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int toplam = 0;
            foreach (T obj in source)
            {
                if (predicate(obj))
                {
                    toplam++;
                }
            }
            return toplam;
        }

        public static double Topla<T>(this IEnumerable<T> source, Func<T, double> predicate)
        {
            double toplam = 0;
            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }
            return toplam;
        }

        public static double? Topla<T>(this IEnumerable<T> source, Func<T, double?> predicate)
        {
            double? toplam = 0;
            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }
            return toplam;
        }

        public static int Topla<T>(this IEnumerable<T> source, Func<T, int> predicate)
        {
            int toplam = 0;
            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }
            return toplam;
        }

        public static int? Topla<T>(this IEnumerable<T> source, Func<T, int?> predicate)
        {
            int? toplam = 0;
            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }
            return toplam;
        }

        public static double Ortalama<T>(this IEnumerable<T> source, Func<T, int> predicate)
        {
            int toplam = 0;

            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }

            return toplam / source.Say();
        }

        public static double Ortalama<T>(this IEnumerable<T> source, Func<T, double> predicate)
        {
            double toplam = 0;

            foreach (T obj in source)
            {
                toplam += predicate(obj);
            }

            return toplam / source.Say();
        }

        public static bool BizimAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T obj in source)
            {
                if (predicate(obj))
                    return true;
            }
            return false;
        }

        public static bool BizimAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T obj in source)
            {
                if (!predicate(obj))
                    return false;
            }
            return true;
        }

        public static T[] DiziyeDoldur<T>(this IEnumerable<T> source)
        {
            int index = 0;
            T[] dizi = new T[source.Say()];

            foreach (T obj in source)
            {
                dizi[index++] = obj;
                //index önce kullanılır, sonra değeri bir artırılır.
            }

            return dizi;
        }

        public static T IlkiniGetir<T>(this IEnumerable<T> source)
        {
            foreach (T obj in source)
            {
                return obj;
            }

            throw new NullReferenceException();
        }

        public static T IlkiniGetir<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T obj in source)
            {
                if (predicate(obj))
                {
                    return obj;
                }
            }
            throw new NullReferenceException();
        }

        public static T IlkiniYadaVarsayilaniGetir<T>(this IEnumerable<T> source) where T : new()
        {
            T defaultType = new T();

            foreach (T obj in source)
            {
                return obj;
            }

            return defaultType;
        }

        public static T IlkiniYadaVarsayilaniGetir<T>(this IEnumerable<T> source, Func<T, bool> predicate) where T : new()
        {
            T defaultType = new T();

            foreach (T obj in source)
            {
                if (predicate(obj))
                {
                    return obj;
                }
            }

            return defaultType;
        }
    }
}
