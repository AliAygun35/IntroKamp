using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> // Ben MYList'imde T ile çalışacağım demektir. Bana bir tip ver ben aşağıyı ona göre yapılandırcam demektir. İnt, String vs.
    {
        T[] items; // MyList'in çalışabilmesi için arka planda kullanılacak diziyi oluşturuyoruz.
        // Constructor ---> https://www.youtube.com/watch?v=_gadwBmkAJ0&t=5s
        public MyList()
        {
            items = new T[0]; // Ancak bu diziyi newlememiz ve kaç eleman tutacağını söylememiz gerek. Bunun için "ctor" kullanıyoruz. Yani constructorleri!
        }
        public void Add(T item) // item eleman demektir. item yerine başka bir şey de yazılabilir.
        {
            T[] tempArray = items; // Items dizisini geçici dizide tutar. Bu şu demektir: Geçici dizinin referansı items'in referansıdır. Artık elemanlar kaybolmaz.
                                   // Ondan sonra eleman sayısını bir arttırıyoruz. 
            items = new T[items.Length+1]; // items dizisinin eleman sayısını 1 arttırıyoruz. Ancak 2. elemanı eklediğimizde dizinin diğer elemanlarını kaybetmemek
                                           // için dizinin referans adresini bir üst satırdaki gibi geçici bir dizide tutuyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        } 
                        
    }
}

// Listeler arka planda array yönetirler, kullanırlar.