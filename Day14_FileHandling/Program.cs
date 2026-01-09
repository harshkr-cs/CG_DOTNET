// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

class Programme{

    public static void Main(string[] args){
        // string path="data.txt";
        // File.WriteAllText(path,"File I/O Example in C#");//if file not created ,create file and write content on it.other wise write on created file
        // File.WriteAllText(path,"File I/O Example is Replaced not Appended.");//old content is Replaced with new content, not appended
        // Console.WriteLine("File wrote successfully.");

        // string content = File.ReadAllText("data.txt");//Read file from data.txt file
        // Console.WriteLine("File Content:");
        // Console.WriteLine(content);

        // using (StreamWriter writer = new StreamWriter("log.txt"))
        // {
        //     writer.WriteLine("Application Started");
        //     writer.WriteLine("Processing Data");
        //     writer.WriteLine("Application Ended");
        // }

        //  using (StreamReader reader = new StreamReader("log.txt"))
        // {
        //     string line;
        //     while ((line = reader.ReadLine()) != null) // null vheck
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        
        //Persisting Object State Using StreamWriter (Text-Based)
        // User user = new User { Id = 1, Name = "Alice" };

        // using (StreamWriter writer = new StreamWriter("user.txt")){//created user.txt manually
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        //     user.Id=2;
        //     user.Name="Harsh Kumar";
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        // }

        // Console.WriteLine("User data saved.");
        
        // User user = new User();
        // //Reading line by line
        // using (StreamReader reader = new StreamReader("user.txt"))
        // {
        //     //object reconstruction
        //     user.Id = int.Parse(reader.ReadLine());//1
        //     user.Name = reader.ReadLine();//Alice
        // }

        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        //Persisting Object State Using BinaryWriter 
        // User user=new User {Id = 2,Name="Bob"};

        // using (BinaryWriter writer=new BinaryWriter(File.Open("user.bin",FileMode.Create)))
        // {
        //     writer.Write(user.Id);
        //     writer.Write(user.Name);
        // }
        // Console.WriteLine("Binary user data saved");
        
       

        // using (BinaryReader reader=new BinaryReader(File.Open("data.bin",FileMode.Open)))
        // {
        //     Console.WriteLine(reader.ReadInt32());
        //     Console.WriteLine(reader.ReadString());
        // }
        
        //FileInfo class->it help me access metadata (name, size, creation time, etc.)
        // FileInfo file=new FileInfo("sample.txt");

        // if(!file.Exists){
        //     using (StreamWriter writer= file.CreateText()){
        //         writer.WriteLine("Hello FileInfo Class");
        //     }
        // }

        // Console.WriteLine("File Name: "+file.Name);
        // Console.WriteLine("File Size: "+file.Length +" bytes");
        // Console.WriteLine("Created on: "+ file.CreationTime);

        //Directory class & DirectoryInfo class 
        //Directory → static, quick operations
        //DirectoryInfo → object-based, metadata access
        // Directory.CreateDirectory("Logs");
        // if(Directory.Exists("Logs")){
        //     Console.WriteLine("Logs directory created successfully.");
        // }

        // DirectoryInfo dir=new DirectoryInfo("Logs");
        // if(!dir.Exists){
        //     dir.Create();
        // }

        // Console.WriteLine("Directory Name: "+ dir.Name);
        // Console.WriteLine("Created on: "+ dir.CreationTime);
        // Console.WriteLine("Full Path: "+ dir.FullName);

        //---------------------------------------------------------Serialization---------------------------------------------
    //    I convert an object into a format that can be:
    //    Stored in a file
    //    Sent over network
    //    Shared between applications
        // User user=new User{
        //     Id=1,Name="Alice"
        // };
        // string json=JsonSerializer.Serialize(user);
        // File.WriteAllText("user.json",json);
        // Console.WriteLine("User Seialized successfully.");
        
        //Deserialize->convert JSON data back into a object.
        // string json=File.ReadAllText("user.json.");
        // User user=JsonSerializer.Deserialize<User>(json);
        // Console.WriteLine("User Loaded: "+ user.Id +" "+ user.Name);

        User user=new User {Id=1,Name="Alice"};
        XmlSerializer serializer=new XmlSerializer(typeof(User));
        using(FileStream fs = new FileStream("user.xml",FileMode.Create)){
            serializer.Serialize(fs,user);
        }

        Console.WriteLine("XML Serialized");


    }
}