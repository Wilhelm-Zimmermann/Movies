using Movies.Domain.Commands;
using System;
using Xunit;

namespace Movies.Domain.Tests.CommandTests
{
    public class CreateMovieCommandTest
    {
        private readonly CreateMovieCommand _validCommand;
        private readonly CreateMovieCommand _invalidCommand;

        public CreateMovieCommandTest()
        {
            _validCommand = new CreateMovieCommand("Os vingadores", "filme de ação e super heróis", new TimeSpan(1,20,10), "Ação", 10);
            _invalidCommand = new CreateMovieCommand("", "filme de ação e super heróis", new TimeSpan(1,20,10), "Ação", 10);
        }

        [Fact]
        public void ShouldBeAbleToCreateACommand()
        {
            _validCommand.Validate();
            Assert.True(_validCommand.Valid);
        }
        [Fact]
        public void ShouldNotBeAbleToCreateACommandWithEmptyTitle()
        {
            _invalidCommand.Validate();
            Assert.True(_invalidCommand.Invalid);
        }
    }
}
