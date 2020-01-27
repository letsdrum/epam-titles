using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.PatternDesign.Singleton
{
    public sealed class OperatingSystemSingleton
    {
        /// <summary>
        /// Закрытые, статическое поле класса, в котором хранится единственный экземпляр
        /// класса одиночки. Инициализация экземпляра выполнится "лениво", т.е. будет
        /// выполняться только при первом обращении.
        /// Также данная конструкция гарантирует, что при обращении из нескольких потоков будет
        /// создан только один экземпляр.
        /// </summary>
        private static readonly Lazy<OperatingSystemSingleton> instance = 
            new Lazy<OperatingSystemSingleton>(() => new OperatingSystemSingleton());


        /// <summary>
        /// Открытое свойство для получения доступа к экземпляру классу одиночки
        /// </summary>
        public static OperatingSystemSingleton Instance { get { return instance.Value; } }

        public static void Alert()
        {
            Console.WriteLine("Operation System started.");
        }
    }
}
