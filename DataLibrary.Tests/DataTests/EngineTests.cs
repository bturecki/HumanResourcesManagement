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
        private readonly Mock<IEngine> engineMock = new Mock<IEngine>();

        [Fact]
        public void GetAllPeople_Returns_List_Of_IPersonModel()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllPeople())
                .Returns(new List<IPersonModel>());

            // Act
            List<IPersonModel> result = engineMock.Object.GetAllPeople();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<IPersonModel>>(result);
        }

        [Fact]
        public void GetAllDepartaments_Returns_List_Of_IDepartament()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllDepartaments())
                .Returns(new List<IDepartament>());

            // Act
            List<IDepartament> result = engineMock.Object.GetAllDepartaments();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<IDepartament>>(result);
        }

        [Fact]
        public void GetAllVacations_Returns_List_Of_IPersonVacation()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllVacations())
                .Returns(new List<IPersonVacation>());

            // Act
            List<IPersonVacation> result = engineMock.Object.GetAllVacations();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<IPersonVacation>>(result);
        }

        [Fact]
        public void GetAllWorkingHours_Returns_List_Of_IPersonWorkingHours()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllWorkingHours())
                .Returns(new List<IPersonWorkingHours>());

            // Act
            List<IPersonWorkingHours> result = engineMock.Object.GetAllWorkingHours();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<IPersonWorkingHours>>(result);
        }

        [Fact]
        public void GetAllCredintialsLogins_Returns_List_Of_ICustomCredintials()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllCredintialsLogins())
                .Returns(new List<ICustomCredintials>());

            // Act
            List<ICustomCredintials> result = engineMock.Object.GetAllCredintialsLogins();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<ICustomCredintials>>(result);
        }

        [Fact]
        public void CheckIfLoginCredintialsAreValid_Returns_True_For_Valid_Credentials()
        {
            // Arrange
            string login = "test";
            string password = "password";
            engineMock.Setup(x => x.CheckIfLoginCredintialsAreValid(login, password))
                .Returns(true);

            // Act
            bool result = engineMock.Object.CheckIfLoginCredintialsAreValid(login, password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckIfLoginCredintialsAreValid_Returns_False_For_Invalid_Credentials()
        {
            // Arrange
            string login = "test";
            string password = "password";
            engineMock.Setup(x => x.CheckIfLoginCredintialsAreValid(login, password))
                .Returns(false);

            // Act
            bool result = engineMock.Object.CheckIfLoginCredintialsAreValid(login, password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CheckIfIsAdmin_Returns_True_For_Admin_Login()
        {
            // Arrange
            string login = "admin";
            engineMock.Setup(x => x.CheckIfIsAdmin(login))
                    .Returns(true);

            // Act
            bool result = engineMock.Object.CheckIfIsAdmin(login);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckIfIsAdmin_Returns_False_For_Non_Admin_Login()
        {
            // Arrange
            string login = "user";
            engineMock.Setup(x => x.CheckIfIsAdmin(login))
            .Returns(false);

            // Act
            bool result = engineMock.Object.CheckIfIsAdmin(login);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SavePerson_Calls_SavePerson_Method()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;

            // Act
            engineMock.Object.SavePerson(person);

            // Assert
            engineMock.Verify(x => x.SavePerson(person), Times.Once);
        }

        [Fact]
        public void DeletePerson_Calls_DeletePerson_Method()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;

            // Act
            engineMock.Object.DeletePerson(person);

            // Assert
            engineMock.Verify(x => x.DeletePerson(person), Times.Once);
        }

        [Fact]
        public void SendMailAsync_Calls_SendMailAsync_Method()
        {
            // Arrange
            IMailToSend mailToSend = new Mock<IMailToSend>().Object;

            // Act
            engineMock.Object.SendMailAsync(mailToSend);

            // Assert
            engineMock.Verify(x => x.SendMailAsync(mailToSend), Times.Once);
        }

        [Fact]
        public void AddLoginLog_Calls_AddLoginLog_Method()
        {
            // Arrange
            string login = "test";
            DateTime dateTime = DateTime.Now;
            EnumLoginLogType loginLogType = EnumLoginLogType.Login;

            // Act
            engineMock.Object.AddLoginLog(login, dateTime, loginLogType);

            // Assert
            engineMock.Verify(x => x.AddLoginLog(login, dateTime, loginLogType), Times.Once);
        }

        [Fact]
        public void GetAllLoginLogs_Returns_List_Of_ILoginLogs()
        {
            // Arrange
            engineMock.Setup(x => x.GetAllLoginLogs())
                .Returns(new List<ILoginLogs>());

            // Act
            List<ILoginLogs> result = engineMock.Object.GetAllLoginLogs();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<ILoginLogs>>(result);
        }

        [Fact]
        public void DeleteVacation_Calls_DeleteVacation_Method()
        {
            // Arrange
            IPersonVacation vacation = new Mock<IPersonVacation>().Object;

            // Act
            engineMock.Object.DeleteVacation(vacation);

            // Assert
            engineMock.Verify(x => x.DeleteVacation(vacation), Times.Once);
        }

        [Fact]
        public void UpdatePerson_Calls_UpdatePerson_Method()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;

            // Act
            engineMock.Object.UpdatePerson(person);

            // Assert
            engineMock.Verify(x => x.UpdatePerson(person), Times.Once);
        }

        [Fact]
        public void SaveDepartament_Calls_SaveDepartament_Method()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            engineMock.Object.SaveDepartament(departament);

            // Assert
            engineMock.Verify(x => x.SaveDepartament(departament), Times.Once);
        }
        [Fact]
        public void DeleteDepartament_Calls_DeleteDepartament_Method()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            engineMock.Object.DeleteDepartament(departament);

            // Assert
            engineMock.Verify(x => x.DeleteDepartament(departament), Times.Once);
        }

        [Fact]
        public void UpdateDepartament_Calls_UpdateDepartament_Method()
        {
            // Arrange
            IDepartament departament = new Mock<IDepartament>().Object;

            // Act
            engineMock.Object.UpdateDepartament(departament);

            // Assert
            engineMock.Verify(x => x.UpdateDepartament(departament), Times.Once);
        }

        [Fact]
        public void AddPersonVacation_Calls_AddPersonVacation_Method()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;
            DateTime dateFrom = DateTime.Now;
            DateTime dateTo = DateTime.Now.AddDays(5);

            // Act
            engineMock.Object.AddPersonVacation(person, dateFrom, dateTo);

            // Assert
            engineMock.Verify(x => x.AddPersonVacation(person, dateFrom, dateTo), Times.Once);
        }

        [Fact]
        public void CanSaveVacation_Returns_True_If_Vacation_Dates_Are_Available()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;
            DateTime dateFrom = DateTime.Now.AddDays(10);
            DateTime dateTo = DateTime.Now.AddDays(15);

            engineMock.Setup(x => x.CanSaveVacation(person, dateFrom, dateTo))
                .Returns(true);

            // Act
            bool result = engineMock.Object.CanSaveVacation(person, dateFrom, dateTo);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanSaveVacation_Returns_False_If_Vacation_Dates_Are_Not_Available()
        {
            // Arrange
            IPersonModel person = new Mock<IPersonModel>().Object;
            DateTime dateFrom = DateTime.Now.AddDays(10);
            DateTime dateTo = DateTime.Now.AddDays(15);

            engineMock.Setup(x => x.CanSaveVacation(person, dateFrom, dateTo))
                .Returns(false);

            // Act
            bool result = engineMock.Object.CanSaveVacation(person, dateFrom, dateTo);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SavePersonWorkingHours_Calls_SavePersonWorkingHours_Method()
        {
            // Arrange
            IPersonWorkingHours personWorkingHours = new Mock<IPersonWorkingHours>().Object;
            TimeSpan timeFrom = new TimeSpan(8, 0, 0);
            TimeSpan timeTo = new TimeSpan(16, 0, 0);

            // Act
            engineMock.Object.SavePersonWorkingHours(personWorkingHours, timeFrom, timeTo);

            // Assert
            engineMock.Verify(x => x.SavePersonWorkingHours(personWorkingHours, timeFrom, timeTo), Times.Once);
        }
    }
}
