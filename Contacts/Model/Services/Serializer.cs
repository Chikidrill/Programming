using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Contacts.Model.Services;

/// <summary>
/// Класс, выполняющий сериализацию и десериализацию контактов в JSON-файл.
/// </summary>
public class Serializer
{
    /// <summary>
    /// Путь к папке "Мои документы" текущего пользователя.
    /// </summary>
    public static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    /// <summary>
    /// Путь к директории, где хранятся файлы контактов.
    /// </summary>
    public static string contactsDir = Path.Combine(documentsPath, "Contacts");

    /// <summary>
    /// Путь к JSON-файлу, в котором хранятся контакты.
    /// </summary>
    private readonly string _filePath = Path.Combine(contactsDir, "contacts.json");

    /// <summary>
    /// Сохраняет переданный контакт в JSON-файл.
    /// </summary>
    /// <param name="contact">Контакт, который необходимо сохранить.</param>
    public void Save(IEnumerable<Contact> contacts)
    {
        try
        {
            if (!Directory.Exists(contactsDir))
            {
                Directory.CreateDirectory(contactsDir);
            }
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка при сохранении контактов: " + ex.Message);
        }
    }

    /// <summary>
    /// Загружает контакт из JSON-файла.
    /// </summary>
    public List<Contact> Load()
    {
        try
        {
            if (!File.Exists(_filePath))
            {
                return new List<Contact>();
            }

            string json = File.ReadAllText(_filePath);
            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
            return contacts;
        }
        catch (Exception)
        {
            return new List<Contact>();
        }
    }
}

