using NUnit.Framework;

using JsonApi.Controllers;

using JsonApi.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

using System.Threading.Tasks;



namespace JsonApi.Tests

{

    [TestFixture]

    public class DataControllerTests

    {

        private DataController _controller;



        [SetUp]

        public void Setup()

        {

            _controller = new DataController();

        }



        [Test]

        public async Task Get_ReturnsListOfModels()

        {

            // Act 

            var result = await _controller.Get();



            // Assert 

            Assert.IsNotNull(result);

            Assert.IsInstanceOf<List<Model>>(result);

        }



        [Test]

        public async Task Post_ReturnsOkResult()

        {

            // Arrange 

            var model = new Model { Id = 1, Name = "Test", Age = 25 };



            // Act 

            var result = await _controller.Post(model);



            // Assert 

            Assert.IsNotNull(result);

            Assert.IsInstanceOf<OkResult>(result);

        }

    }

}