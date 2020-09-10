//using BusinessLogic.Students;
//using DataAccess;
//using Moq;
//using NUnit.Framework;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;

//namespace BusinessLogicUnitTests.Students.StudentBusinessLogicTests
//{
//    public class BadMethodWhichDoMillionOfThingsTests
//    {
//        //HappyPath
//        [Test]
//        public void ShouldReturnStudentNameInUpperCase_WhenSuccess()
//        {
//            //arrange
//            //SUT = System Under Test   //Method Under Test
//            var fakeDA = new LazyFakeStudentDataAccess();
//            var sut = new StudentBusinessLogic(fakeDA);
//            string anyStudnetName = "name";

//            //act
//            var result = sut.BadMethodWhichDoMillionOfThings(anyStudnetName);

//            //assert
//            var expectedName = anyStudnetName.ToUpper();
//            Assert.AreEqual(expectedName, result);
//        }

//        public class LazyFakeStudentDataAccess : IStudentDataAccess
//        {
//            public void AddStudent(string student)
//            {
//                throw new System.NotImplementedException();
//            }

//            public int GetMark(string studentName)
//            {
//                throw new System.NotImplementedException();
//            }

//            public IEnumerable<string> ListStudents()
//            {
//                throw new System.NotImplementedException();
//            }
//        }

//        [Test]
//        public void ShouldReturnTotalStudentsNumber_WhenStudentIsLector_OldSchool()
//        {
//            //arrange
//            var fakeDA = new LectorStudentDataAccessStub();
//            var sut = new StudentBusinessLogic(fakeDA);
//            var specialLectorStudentName = "Lector";

//            var expectedNumber = fakeDA.ListStudents().Count().ToString();

//            //act
//            var result = sut.BadMethodWhichDoMillionOfThings(specialLectorStudentName);

//            //assert
//            Assert.That(result, Is.EqualTo(expectedNumber));
//        }

//        public class LectorStudentDataAccessStub : IStudentDataAccess
//        {
//            public void AddStudent(string student)
//            {
//                throw new System.NotImplementedException();
//            }

//            public int GetMark(string studentName)
//            {
//                throw new System.NotImplementedException();
//            }

//            public IEnumerable<string> ListStudents()
//            {
//                return new List<string> { "Bob", "Matt" };
//            }
//        }

//        [Test]
//        public void ShouldReturnTotalStudentsNumber_WhenStudentIsLector()
//        {
//            //arrange
//            var listOfStudents = new List<string> { "Bob", "Matt" };

//            var studentDAMock = new Mock<IStudentDataAccess>();
//            studentDAMock.Setup(x => x.ListStudents()).Returns(listOfStudents);

//            var sut = new StudentBusinessLogic(studentDAMock.Object);
//            var specialLectorStudentName = "Lector";


//            //act
//            var result = sut.BadMethodWhichDoMillionOfThings(specialLectorStudentName);

//            //assert
//            var expectedNumber = listOfStudents.Count().ToString();
//            Assert.That(result, Is.EqualTo(expectedNumber));
//        }

//        //public void ShouldAddStudentToRepository_WhenStudentIsAlex()
//        //{
//                //check if method was called (potentially with concrete value)
//        //}


//        //NUnit, MOQ, FluentAssertions, //extra: AutoFixture (AutoMock, Bogus).
//    }
//}
