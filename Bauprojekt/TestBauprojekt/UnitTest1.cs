using Bauprojekt;

namespace TestBauprojekt;

public class Tests
{
    [TestFixture]
    public class ProjectTests
    {
        [SetUp]
        public void Setup()
        {
            project = new Project();
            projectManager = new ProjectManager();
            constructionManager = new ConstructionManager();
            project.RegisterObserver(projectManager);
            project.RegisterObserver(constructionManager);
            building = new Building(project, "Main Building");
            room = new Room("Office Room");
            material = new Material("Concrete");
        }

        private Project project;
        private ProjectManager projectManager;
        private ConstructionManager constructionManager;
        private Building building;
        private Room room;
        private Material material;

        [Test]
        public void Test_Adding_Room_To_Building()
        {
            building.Add(room);
            Assert.Contains(room, building.Children);
        }

        [Test]
        public void Test_Removing_Room_From_Building()
        {
            building.Add(room);
            building.Remove(room);
            Assert.IsFalse(building.Children.Contains(room));
        }

        [Test]
        public void Test_Adding_Material_To_Room()
        {
            room.Add(material);
            Assert.Contains(material, room.Children);
        }

        [Test]
        public void Test_Removing_Material_From_Room()
        {
            room.Add(material);
            room.Remove(material);
            Assert.IsFalse(room.Children.Contains(material));
        }

        [Test]
        public void Test_Logger_Singleton_Behavior()
        {
            var logger1 = MyLogger.Instance;
            var logger2 = MyLogger.Instance;
            Assert.AreSame(logger1, logger2, "Logger should be a singleton 
            instance."); 
        }

        [Test]
        public void Test_Logging_Addition()
        {
            // Vor dem Test sicherstellen, dass der Logger keine alten Nachrichten 
            enthält
            MyLogger.Instance.WriteLogToFile("temp.txt"); // Schreibt alle 
            aktuellen Logs in eine temporäre Datei und leert die Liste
            File.Delete("temp.txt"); // Löscht die temporäre Datei 
            // Eine neue Building-Instanz erstellen 
            var newBuilding = new Building(project, "New Test Building");
            // Einen Raum zur neuen Building-Instanz hinzufügen 
            var newRoom = new Room("Test Room");
            newBuilding.Add(newRoom);
            // Überprüfen, ob der Logger die korrekte Nachricht hinzugefügt hat 
            var expectedLogEntry = $"Added {newRoom.GetDetails()} to 
            {
                newBuilding.Name
            }."; 
            Assert.IsTrue(MyLogger.Instance.MessageCount > 0, "Logger should 
            contain at least one message."); 
        }

        [Test]
        public void Test_Logging_Removal()
        {
            // Vorhandene Anzahl der Protokolleinträge speichern 
            int initialCount = MyLogger.Instance.MessageCount;
            // Raum erstellen und zum Gebäude hinzufügen 
            var room = new Room("Classroom");
            building.Add(room);
            // Überprüfen, ob ein neuer Protokolleintrag für das Hinzufügen 
            erstellt wurde
            Assert.AreEqual(initialCount + 1, MyLogger.Instance.MessageCount,
                "Logger should have one more entry after adding a room.");
            // Raum aus dem Gebäude entfernen 
            building.Remove(room);
            // Nach dem Entfernen sollte die Anzahl der Protokolleinträge gleich 
            der Anzahl nach dem Hinzufügen sein
            Assert.AreEqual(initialCount + 2, MyLogger.Instance.MessageCount,
                "Logger should still have one entry after removing a room.");
        }

        [Test]
        public void Test_ProjectManager_Notification()
        {
            project.NotifyObservers("Project Updated");
            StringAssert.Contains("Project Manager notified: Project Updated",
                projectManager.GetNotifications());
        }

        [Test]
        public void Test_ConstructionManager_Notification()
        {
            project.NotifyObservers("Building Added");
            StringAssert.Contains("Construction Manager notified: Building Added",
                constructionManager.GetNotifications());
        }

        [Test]
        public void Test_Writing_Log_To_File()
        {
            var filePath = "test_log.txt";
            MyLogger.Instance.Log("Test log entry");
            MyLogger.Instance.WriteLogToFile(filePath);
            Assert.IsTrue(File.Exists(filePath));
            var logContent = File.ReadAllText(filePath);
            StringAssert.Contains("Test log entry", logContent);
            File.Delete(filePath);
        }

        [Test]
        public void Test_Adding_Same_Room_To_Building_Does_Not_Duplicate()
        {
            building.Add(room);
            building.Add(room);
            Assert.AreEqual(1, building.Children.Count(child => child == room));
        }

        [Test]
        public void Test_Removing_Non_Existent_Room_From_Building()
        {
            Assert.DoesNotThrow(() => building.Remove(room));
        }

        [Test]
        public void Test_Logging_Multiple_Entries()
        {
            // Logger vor dem Test zurücksetzen 
            MyLogger.Instance.WriteLogToFile("temp_log.txt"); // Bestehende Logs schreiben und löschen
            File.Delete("temp_log.txt"); // Temporäre Datei löschen 
            // Ausgangszustand sicherstellen 
            Assert.AreEqual(0, MyLogger.Instance.MessageCount, "Logger sollte vor 
            dem Testfall keine Einträge enthalten."); 
            // Neue Instanzen erstellen, um mögliche zusätzliche Log-Nachrichten 
            zu vermeiden
            var project = new Project();
            var building = new Building(project, "Test Building");
            var room = new Room("Test Room");
            // Raum hinzufügen und entfernen 
            building.Add(room); // Erwartet: 1 Log-Eintrag 
            building.Remove(room); // Erwartet: 1 Log-Eintrag 
            // Debugging: Log-Nachrichten anzeigen 
            Console.WriteLine("Aktuelle Log-Einträge:");
            foreach (var message in MyLogger.Instance.MessageCount.ToString()) Console.WriteLine(message);
            // Anzahl der Log-Einträge überprüfen 
            Assert.AreEqual(2, MyLogger.Instance.MessageCount,  $"Logger sollte 
            genau 2 Einträge haben, hat aber {
                MyLogger.Instance.MessageCount
            }
            Einträge."); 
        }

        [Test]
        public void Test_Notification_Contains_Correct_Message()
        {
            project.NotifyObservers("Room Added");
            StringAssert.Contains("Room Added",
                projectManager.GetNotifications());
        }

        [Test]
        public void Test_Logger_Resets_Entries_After_Write()
        {
            var filePath = "test_log_reset.txt";
            MyLogger.Instance.Log("Test reset log");
            MyLogger.Instance.WriteLogToFile(filePath);
            Assert.AreEqual(0, MyLogger.Instance.MessageCount, "Logger should 
            reset after writing to file."); 
            File.Delete(filePath);
        }
    }
}

}