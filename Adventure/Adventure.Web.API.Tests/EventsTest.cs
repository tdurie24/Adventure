using System.Threading.Tasks;
using Adventure.Contracts;
using Adventure.Contracts.Models;
using Adventure.Domain.Entities;
using AutoFixture;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests
{

    public class EventsTest
    {
        private IFixture fixture;
        private Mock<IEventsServices> eventService;

        [SetUp]
        public void Setup()
        {
            this.fixture = new Fixture();
            this.eventService = new Mock<IEventsServices>();
        }

        [Test]
        public void Create_WithValidEvent_ShouldCreate()
        {
            //arrange
            var eventObject = this.fixture.Create<EventDto>();

            //act
            var eventId = eventService.Setup(x => x.CreateEvent(eventObject)).Returns(Task.FromResult(It.IsAny<string>()));
            //assert
            eventId.Should().NotBeNull();
        }
    }
}