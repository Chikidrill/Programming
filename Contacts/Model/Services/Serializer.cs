using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Класс, выполняющий сериализацию и десериализацию контактов в JSON-файл.
    /// </summary>
    public class Serializer
    {
        private readonly string _filePath;

        /// <summary>
        /// Сохраняет переданный контакт в JSON-файл.
        /// </summary>
        /// <param name="contact">Контакт, который необходимо сохранить.</param>
        public void Save(Contact contact)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при сохранении контакта: " + ex.Message);
            }
        }

        /// <summary>
        /// Загружает контакт из JSON-файла.
        /// </summary>
        public Contact Load()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return new Contact();

                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Contact>(json) ?? new Contact();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при загрузке контакта: " + ex.Message);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Serializer"/> 
        /// и задает путь к файлу для хранения контактов.
        /// </summary>
        public Serializer()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string contactsDir = Path.Combine(documentsPath, "Contacts");

            if (!Directory.Exists(contactsDir))
                Directory.CreateDirectory(contactsDir);

            _filePath = Path.Combine(contactsDir, "contacts.json");
        }
    }
}
