using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNubeDePalabras
{
    [TestClass]
    public class TestEstudiante
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        /// <summary>
        /// Tests para verificar nombre.
        /// </summary>
        [TestMethod]
        
        public void TestVerificarNombre()
        {
            // Arranque
            String Nombre = "Lucas";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarNombre(Nombre);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Nombres$",
         DataAccessMethod.Sequential)]
        public void TestVerificarNombre1()
        {
            // Arranque
            String Nombre = Convert.ToString(TestContext.DataRow["Nombres"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarNombre(Nombre);

            //Assert
            Assert.AreEqual(true, respues);
        }

        /// <summary>
        /// Tests para verificar apellido.
        /// </summary>
        [TestMethod]
        public void TestVerificarApellido()
        {
            // Arranque
            String Apellido = "Rojas";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarApellido(Apellido);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Apellidos$",
         DataAccessMethod.Sequential)]
        public void TestVerificarApellido1()
        {
            // Arranque
            String apellido = Convert.ToString(TestContext.DataRow["Apellidos"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarApellido(apellido);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Respuesta1$",
         DataAccessMethod.Sequential)]
        public void TestVerificarDatosIdea1()
        {
            // Arranque
            String idea1 = Convert.ToString(TestContext.DataRow["Respuesta1"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea1(idea1);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar rpimera Respuesta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea1()
        {
            // Arranque
            String Idea1 = "Java";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea1(Idea1);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar segunda Pregunta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea2()
        {
            // Arranque
            String Idea2 = "Phyton";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea2(Idea2);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Respuesta2$",
         DataAccessMethod.Sequential)]
        public void TestVerificarDatosIdea2()
        {
            // Arranque
            String idea2 = Convert.ToString(TestContext.DataRow["Respuesta2"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.VerificarIdea2(idea2);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests para verificar tercera Pregunta.
        /// </summary>
        [TestMethod]
        public void TestVerificarIdea3()
        {
            // Arranque
            String Idea3 = "c#";
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.Verificaridea3(Idea3);

            //Assert
            Assert.AreEqual(true, respues);
        }
        /// <summary>
        /// Tests de pruebas controlada por datos.
        /// </summary>
        [TestMethod]
        [DataSource("System.Data.OleDB",
         @"Provider=Microsoft.ACE.OLEDB.12.0;
         Data Source=E:\2020-II\Construccion de software\nombres.xlsx;
         Extended Properties='Excel 12.0;
         HDR=yes';",
         "Respuesta3$",
         DataAccessMethod.Sequential)]
        public void TestVerificarDatosIdea3()
        {
            // Arranque
            String idea3 = Convert.ToString(TestContext.DataRow["Respuesta3"]);
            Boolean respues;
            Nube_de_palabras.Estudiante resp = new Nube_de_palabras.Estudiante();

            //Act
            respues = resp.Verificaridea3(idea3);

            //Assert
            Assert.AreEqual(true, respues);
        }

    }
}
