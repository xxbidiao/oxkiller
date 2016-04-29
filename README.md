# oxkiller
OX event answering helper for mabinogi

Welcome to OXkiller project site!

## What is OXKiller?

OXkiller is a quick answer look-up program written in .net c#. It is mainly developed for convenience at "OX event" in mabinogi which ask you to judge whether a statement is true or false.
This program mainly deal with Chinese stataments, and utilized Trie to enhance search experience.
Using this program, you can achieve realtime lookup using initials in a database up to 100k statements.

## Features
* Import statements and its answers in specific format
* Search statements using incomplete initials
* Automatically generates Chinese Pinyin initials and deal with multiple pinyin conversion problem.
* Contains a Chinese sentence to pinyin initial conversion tool (restrictions apply)

## Usage
* Start the oxkiller.exe, or compile it from source. (I currently use vs2013)
* Import the database (If you get it from Release tag, there is already a pre-generated database.)
* Start searching!

## To-dos
* Network database update support.
* English word initial search support.

## You can help!
* Enhance the database by helping out editing raw text.
