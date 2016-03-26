using ean13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEan13
{
    
    
    /// <summary>
    ///Classe de test pour Ean13Test, destinée à contenir tous
    ///les tests unitaires Ean13Test
    ///</summary>
    [TestClass()]
    public class Ean13Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
      [TestMethod()]
        public void Ean13ConstructorTestTableauTropGrand()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8, 0 });
            }
            catch (Exception e)
            {
                Assert.AreEqual("Un code Ean 13 doit être un tableau de 12 entiers, trop grand", e.Message);
                return;
            }
            Assert.Fail("Aucune exception n'a été soulevée");         
        }

      [TestMethod()]
      public void Ean13ConstructorTestTableauTropPetit()
      {
          try
          {
              Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8});
          }
          catch (Exception e)
          {
              Assert.AreEqual("Un code Ean 13 doit être un tableau de 12 entiers, trop petit", e.Message);
              return;
          }
          Assert.Fail("Aucune exception n'a été soulevée");
      }

      [TestMethod()]
      public void Ean13ConstructorTestNombrePasApproprie()
      {
          try
          {
              Ean13 target = new Ean13(new int[] { 4, 7, 1, 1, 5, 1, 2, 0, 0, 2, 8, 8, 0 });
          }
          catch (Exception e)
          {
              Assert.AreEqual("un élément du genocode n'est pas compris entre 0 et 9", e.Message);
              return;
          }
          Assert.Fail("Aucune exception n'a été soulevée");
      } 
        /// <summary>
        ///Test pour Cle
        ///</summary>
        [TestMethod()]
        public void CleTest()
        {
            Ean13 target = new Ean13(new int[] { 3, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual = target.Cle();
       /*     if (actual != 0)
            {*/
                Assert.AreEqual(expected, actual);
             /*
            else
            {
                throw new Exception(
            }*/
        }

        /// <summary>
        ///Test pour Poids
        ///</summary>
        
        /// <summary>
        ///Test pour PoidsImpairs
        ///</summary>
        [TestMethod()]
        public void PoidsImpairsTest()
        { // TODO: initialisez à une valeur appropriée
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }); // TODO: initialisez à une valeur appropriée
            int expected = 20; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsImpairs();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour PoidsPairs
        ///</summary>
        [TestMethod()]
        public void PoidsPairsTest()
        {
            Ean13 target = new Ean13(new int[] {4,7,1,9,5,1,2,0,0,2,8,8}); // TODO: initialisez à une valeur appropriée
            int expected = 81; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsPairs();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour Reste
        ///</summary>
        [TestMethod()]
        public void ResteTest()
        {
            Ean13 target = new Ean13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 }); // TODO: initialisez à une valeur appropriée
            int expected = 1; // TODO: initialisez à une valeur appropriée
            int actual = target.Reste();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Ean13 target = new Ean13(new int[] {4,7,1,9,5,1,2,0,0,2,8,8 }); // TODO: initialisez à une valeur appropriée
            string expected = "4719-5120-0288-9"; // TODO: initialisez à une valeur appropriée
            string actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
