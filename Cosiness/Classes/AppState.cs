using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosiness
{
    public class AppState
    {
        private static Dictionary<string, dynamic> _state = new Dictionary<string, dynamic>(); //Создание словаря

        public static dynamic Get(string key) //Получение объектов
        {
            if (_state.ContainsKey(key)) return _state[key];
            return false;
        }

        public static void Delete(string key) //Удаление объектов
        {
            _state.Remove(key);
        }

        public static void Clear() //Очищение словаря
        {
            _state.Clear();
        }

        public static Dictionary<string, dynamic> All() //Выбор всех объектов
        {
            return _state;
        }

        public static void Add(string key, dynamic value) //Добавление объекта
        {
            if (_state.ContainsKey(key)) return;
            _state[key] = value;
        }
    }
}