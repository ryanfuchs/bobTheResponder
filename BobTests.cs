// This file was auto-generated based on version 1.6.0 of the canonical data.

using Xunit;

public class BobTests
{
    [Fact]
    public void Stating_something()
    {
        //Arrange
        string statement = "TTom-ay-to, tom-aaaah-to.";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Shouting()
    {
        //Arrange
        string statement = "WATCH OUT!";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whoa, chill out!", bobsResponse);
    }

    [Fact]
    public void Shouting_gibberish()
    {
        //Arrange
        string statement = "FCECDFCAAB";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whoa, chill out!", bobsResponse);
    }

    [Fact]
    public void Asking_a_question()
    {
        //Arrange
        string statement = "Does this cryogenic chamber make me look fat?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Asking_a_numeric_question()
    {
        //Arrange
        string statement = "You are, what, like 15?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Asking_gibberish()
    {
        //Arrange
        string statement = "fffbbcbeab?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Talking_forcefully()
    {
        //Arrange
        string statement = "Hi there!";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Using_acronyms_in_regular_speech()
    {
        //Arrange
        string statement = "It's OK if you don't want to go work for NASA.";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Forceful_question()
    {
        //Arrange
        string statement = "WHAT'S GOING ON?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Calm down, I know what I'm doing!", bobsResponse);
    }

    [Fact]
    public void Shouting_numbers()
    {
        //Arrange
        string statement = "1, 2, 3 GO!";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whoa, chill out!", bobsResponse);
    }

    [Fact]
    public void No_letters()
    {
        //Arrange
        string statement = "1, 2, 3";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Question_with_no_letters()
    {
        //Arrange
        string statement = "4?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Shouting_with_special_characters()
    {
        //Arrange
        string statement = "ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whoa, chill out!", bobsResponse);
    }

    [Fact]
    public void Shouting_with_no_exclamation_mark()
    {
        //Arrange
        string statement = "I HATE THE DENTIST";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whoa, chill out!", bobsResponse);
    }

    [Fact]
    public void Statement_containing_question_mark()
    {
        //Arrange
        string statement = "Ending with ? means a question.";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Non_letters_with_question()
    {
        //Arrange
        string statement = ":) ?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Prattling_on()
    {
        //Arrange
        string statement = "Wait! Hang on. Are you going to be OK?";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Sure.", bobsResponse);
    }

    [Fact]
    public void Silence()
    {
        //Arrange
        string statement = "";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Fine. Be that way!", bobsResponse);
    }

    [Fact]
    public void Prolonged_silence()
    {
        //Arrange
        string statement = "          ";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Fine. Be that way!", bobsResponse);
    }

    [Fact]
    public void Alternate_silence()
    {
        //Arrange
        string statement = "\t\t\t\t\t\t\t\t\t\t";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Fine. Be that way!", bobsResponse);
    }

    [Fact]
    public void Multiple_line_question()
    {
        //Arrange
        string statement = "\nDoes this cryogenic chamber make me look fat?\nNo.";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Starting_with_whitespace()
    {
        //Arrange
        string statement = "         hmmmmmmm...";
        string bobsResponse;

        //Act
        bobsResponse = Bob.Response(statement);

        //Assert
        Assert.Equal("Whatever.", bobsResponse);
    }

    [Fact]
    public void Ending_with_whitespace()
    {
        Assert.Equal("Sure.", Bob.Response("Okay if like my  spacebar  quite a bit?   "));
    }

    [Fact]
    public void Other_whitespace()
    {
        Assert.Equal("Fine. Be that way!", Bob.Response("\n\r \t"));
    }

    [Fact]
    public void Non_question_ending_with_whitespace()
    {
        Assert.Equal("Whatever.", Bob.Response("This is a statement ending with whitespace      "));
    }
}