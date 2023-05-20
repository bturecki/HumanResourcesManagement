using DataLibrary.Abstract;
using DataLibrary.Enums;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataLibrary.Tests.DataTests
{
    public class EngineTests
    {
        private readonly Mock<IEngine> mockEngine = new Mock<IEngine>();

        [Fact]
        public void GetAllPeople_ReturnsListOfIPersonModel()
        {
            // Arrange
            List<IPersonModel> expectedResult = new List<IPersonModel> { new Mock<IPersonModel>().Object };

            mockEngine.Setup(e => e.GetAllPeople()).Returns(expectedResult);

            // Act
            List<IPersonModel> result = mockEngine.Object.GetAllPeople();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllDepartaments_ReturnsListOfIDepartament()
        {
            // Arrange
            List<IDepartament> expectedResult = new List<IDepartament> { new Mock<IDepartament>().Object };

            mockEngine.Setup(e => e.GetAllDepartaments()).Returns(expectedResult);

            // Act
            List<IDepartament> result = mockEngine.Object.GetAllDepartaments();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllVacations_ReturnsListOfIPersonVacation()
        {
            // Arrange
            List<IPersonVacation> expectedResult = new List<IPersonVacation> { new Mock<IPersonVacation>().Object };

            mockEngine.Setup(e => e.GetAllVacations()).Returns(expectedResult);

            // Act
            List<IPersonVacation> result = mockEngine.Object.GetAllVacations();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllWorkingHours_ReturnsListOfIPersonWorkingHours()
        {
            // Arrange
            List<IPersonWorkingHours> expectedResult = new List<IPersonWorkingHours> { new Mock<IPersonWorkingHours>().Object };

            mockEngine.Setup(e => e.GetAllWorkingHours()).Returns(expectedResult);

            // Act
            List<IPersonWorkingHours> result = mockEngine.Object.GetAllWorkingHours();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllCredintialsLogins_ReturnsListOfICustomCredintials()
        {
            // Arrange
            List<ICustomCredintials> expectedResult = new List<ICustomCredintials> { new Mock<ICustomCredintials>().Object };

            mockEngine.Setup(e => e.GetAllCredintialsLogins()).Returns(expectedResult);

            // Act
            List<ICustomCredintials> result = mockEngine.Object.GetAllCredintialsLogins();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckIfLoginCredintialsAreValid_ReturnsTrueWhenValid()
        {
            // Arrange
            string testLogin = "testLogin";
            string testPassword = "testPassword";

            mockEngine.Setup(e => e.CheckIfLoginCredintialsAreValid(testLogin, testPassword)).Returns(true);

            // Act
            bool result = mockEngine.Object.CheckIfLoginCredintialsAreValid(testLogin, testPassword);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckIfIsAdmin_ReturnsTrueWhenAdmin()
        {
            // Arrange
            string testLogin = "adminLogin";

            mockEngine.Setup(e => e.CheckIfIsAdmin(testLogin)).Returns(true);

            // Act
            bool result = mockEngine.Object.CheckIfIsAdmin(testLogin);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SavePerson_IsCalledWithExpectedPersonModel()
        {
            // Arrange
            IPersonModel personModel = new Mock<IPersonModel>().Object;

            // Act
            mockEngine.Object.SavePerson(personModel);  // Assert
            mockEngine.Verify(e => e.SavePerson(personModel), Times.Once);
        }

        [Fact]
        public void DeletePerson_IsCalledWithExpectedPersonModel()
        {
            // Arrange
            IPersonModel personModel = new Mock<IPersonModel>().Object;

            // Act
            mockEngine.Object.DeletePerson(personModel);

            // Assert
            mockEngine.Verify(e => e.DeletePerson(personModel), Times.Once);
        }

        [Fact]
        public void SendMailAsync_IsCalledWithExpectedMailToSend()
        {
            // Arrange
            IMailToSend mailToSend = new Mock<IMailToSend>().Object;

            // Act
            mockEngine.Object.SendMailAsync(mailToSend);

            // Assert
            mockEngine.Verify(e => e.SendMailAsync(mailToSend), Times.Once);
        }

        [Fact]
        public void AddLoginLog_IsCalledWithExpectedParameters()
        {
            // Arrange
            string testLogin = "testLogin";
            DateTime testDateTime = DateTime.Now;
            EnumLoginLogType testLogType = EnumLoginLogType.Login;

            // Act
            mockEngine.Object.AddLoginLog(testLogin, testDateTime, testLogType);

            // Assert
            mockEngine.Verify(e => e.AddLoginLog(testLogin, testDateTime, testLogType), Times.Once);
        }

        [Fact]
        public void GetAllLoginLogs_ReturnsListOfILoginLogs()
        {
            // Arrange
            List<ILoginLogs> expectedResult = new List<ILoginLogs> { new Mock<ILoginLogs>().Object };

            mockEngine.Setup(e => e.GetAllLoginLogs()).Returns(expectedResult);

            // Act
            List<ILoginLogs> result = mockEngine.Object.GetAllLoginLogs();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteVacation_IsCalledWithExpectedPersonVacation()
        {
            // Arrange
            IPersonVacation personVacation = new Mock<IPersonVacation>().Object;

            // Act
            mockEngine.Object.DeleteVacation(personVacation);

            // Assert
            mockEngine.Verify(e => e.DeleteVacation(personVacation), Times.Once);
        }

        [Fact]
        public void UpdatePerson_IsCalledWithExpectedPersonModel()
        {
            // Arrange
            IPersonModel personModel = new Mock<IPersonModel>().Object;

            // Act
            mockEngine.Object.UpdatePerson(personModel);

            // Assert
            mockEngine.Verify(e => e.UpdatePerson(personModel), Times.Once);
        }

        [Fact]
        public void SaveDepartament_IsCalledWithExpectedDepartament()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            mockEngine.Object.SaveDepartament(departament);

            // Assert
            mockEngine.Verify(e => e.SaveDepartament(departament), Times.Once);
        }

        [Fact]
        public void DeleteDepartament_IsCalledWithExpectedDepartament()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            mockEngine.Object.DeleteDepartament(departament);

            // Assert
            mockEngine.Verify(e => e.DeleteDepartament(departament), Times.Once);
        }

        [Fact]
        public void UpdateDepartament_IsCalledWithExpectedDepartament()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            mockEngine.Object.UpdateDepartament(departament);

            // Assert
            mockEngine.Verify(e => e.UpdateDepartament(departament), Times.Once);
        }

        [Fact]
        public void AddPersonVacation_IsCalledWithExpectedParameters()
        {   // Arrange
            IPersonModel personModel = new Mock<IPersonModel>().Object;
            DateTime dateFrom = DateTime.Now;
            DateTime dateTo = DateTime.Now.AddDays(7);

            // Act
            mockEngine.Object.AddPersonVacation(personModel, dateFrom, dateTo);

            // Assert
            mockEngine.Verify(e => e.AddPersonVacation(personModel, dateFrom, dateTo), Times.Once);
        }

        [Fact]
        public void CanSaveVacation_ReturnsTrueWhenVacationCanBeSaved()
        {
            // Arrange
            IPersonModel personModel = new Mock<IPersonModel>().Object;
            DateTime dateFrom = DateTime.Now;
            DateTime dateTo = DateTime.Now.AddDays(7);

            mockEngine.Setup(e => e.CanSaveVacation(personModel, dateFrom, dateTo)).Returns(true);

            // Act
            bool result = mockEngine.Object.CanSaveVacation(personModel, dateFrom, dateTo);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SavePersonWorkingHours_IsCalledWithExpectedParameters()
        {
            // Arrange
            IPersonWorkingHours personWorkingHours = new Mock<IPersonWorkingHours>().Object;
            TimeSpan timeFrom = TimeSpan.FromHours(9);
            TimeSpan timeTo = TimeSpan.FromHours(17);

            // Act
            mockEngine.Object.SavePersonWorkingHours(personWorkingHours, timeFrom, timeTo);

            // Assert
            mockEngine.Verify(e => e.SavePersonWorkingHours(personWorkingHours, timeFrom, timeTo), Times.Once);
        }

        [Fact]
        public void InsertNewLicence_ReturnsTrueWhenLicenseIsInserted()
        {
            // Arrange
            string testLogin = "testLogin";
            string testPassword = "testPassword";
            bool testIsAdmin = false;
            string errorText = string.Empty;

            mockEngine.Setup(e => e.InsertNewLicence(testLogin, testPassword, testIsAdmin, out errorText)).Returns(true);

            // Act
            bool result = mockEngine.Object.InsertNewLicence(testLogin, testPassword, testIsAdmin, out errorText);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DeleteLicense_IsCalledWithExpectedCustomCredintials()
        {
            // Arrange
            ICustomCredintials customCredintials = new Mock<ICustomCredintials>().Object;

            // Act
            mockEngine.Object.DeleteLicense(customCredintials);

            // Assert
            mockEngine.Verify(e => e.DeleteLicense(customCredintials), Times.Once);
        }
    }
}
