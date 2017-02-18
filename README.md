# _Word Counter_

#### _Word Counter Website, Epicodus C# Week 2 Code Review, 2.17.17_

#### By _**Caitlin Hines**_

## Description

_This application will allow a user to enter a word and a sentence. The program will then compare the original word with the sentence and output how often the word appears in the sentence._

## Specifications

<!---
This spec will see if the program can recognize an inputted word and output it. It seems like the most simple response.
-->
#### Program will identify the inputted word and return the word.
* Input: "cat"
* Output : "cat"

<!---
After the program outputs a word, the next step is to see if it can identify it in a given sentence and return true or false.
-->
#### Program will identify if the given word appears once in the sentence.
* Input: "cat", "cat in the hat"
* Output : "Your word appears in the sentence"

<!---
Once it can identify if it occurs in the sentence, the next step is to see if it can count how many times it occurs
-->
#### Program will identify the amount of times a word appears in the sentence and return that amount.
* Input: "dog", "My dog is in her dog house"
* Output : 2

<!---
I chose this as my last spec because it is adding on to the counting method
-->
#### Program will identify the inputted word despite case when entered and return correct amount.
* Input: "cat", "Cat in the hat"
* Output : "1"

## Support and contact details

_Contact: Caitlin Hines- caitlinhines@me.com_

## Technologies Used

## Setup/Installation Requirements

* _Clone github repository:https://github.com/Word-Counter
* _reset server with "gnx kestrel"_
* _Open webpage on localhost:5004_

_HTML, CSS, Nancy, Razor, C#_

### License

*MIT*

Copyright (c) 2017 **_Caitlin Hines_**
