//using System;
//using BusinessLogic.Students;
//using DataAccess;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BusinessLogicUnitTests
//{
//    [TestClass]
//    public class StudentBusinessLogicTests
//    {
//        [TestMethod]
//        public void UppercaseTheName_RegularString_NameIsMadeUppercase()
//        {
//            //Arrange
//            IStudentDataAccess studentRepository = new FakeStudentDataAccess();
//            IStudentBusinessLogic _studentLogic = new StudentBusinessLogic(studentRepository);
//            var studentParam = "Alex";
//            var expectedStudent = "ALEX";

//            //Act
//            var result = _studentLogic.BadMethodWhichDoMillionOfThings(studentParam);

//            //Assert
//            Assert.AreEqual(expectedStudent, result);
//            //we can also evaluate how many times each method of the fake repository (fake dependency) has been used/hit.
//        }
//    }
//}
