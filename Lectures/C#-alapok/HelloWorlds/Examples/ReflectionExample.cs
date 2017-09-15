using System;

namespace Examples
{
    public class ReflectionExample
    {
        public int Value;
        public string Name;

        public void EchoFields(Type type)
        {
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
                Console.WriteLine(field.FieldType);

                
            }

            var destObj = Activator.CreateInstance(type);

            var valueField = type.GetField("Value");
            var nameField = type.GetField("Value");

            valueField.SetValue(destObj, 10);
            nameField.SetValue(destObj, "Test");
        }
    }
}
