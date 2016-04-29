# oxkiller
OX event answering helper for mabinogi

Welcome to OXkiller project site!
欢迎来到洛奇OX帮助器的Github站！

This program is open-source under MIT licence, please help yourself improving it!
这个程序是基于MIT协议发布，欢迎一起改进！

## What is OXKiller? （这是什么？）

OXkiller is a quick answer look-up program written in .net c#. It is mainly developed for convenience at "OX event" in mabinogi which ask you to judge whether a statement is true or false.
This program mainly deal with Chinese stataments, and utilized Trie to enhance search experience.
Using this program, you can achieve realtime lookup using initials in a database up to 100k statements.
这个程序使用了.net C#，可以让你快速的用中文首字母查询到对应的OX问题。

## Features（特色）
* Import statements and its answers in specific format （可以导入题库）
* Search statements using incomplete initials （使用不完整首字母搜索）
* Automatically generates Chinese Pinyin initials and deal with multiple pinyin conversion problem. （自动生成中文拼音首字母并处理多音字问题）
* Contains a Chinese sentence to pinyin initial conversion tool (restrictions apply) （含有一个中文到拼音首字母的转换工具（有限制））

## Usage（使用方法）
* Start the oxkiller.exe, or compile it from source. (I currently use vs2013) （直接开启oxkiller.exe或者进行编译。）
* Import the database (If you get it from Release tag, there is already a pre-generated database.)（导入数据库。如果你从Release标签下载你会直接获取到数据库。）
* Start searching! （开始干！）

## To-dos （之后的计划）
* Network database update support. （在线更新题库支持）
* English word initial search support. （英语词首字母搜索）

## You can help! （你也可以帮忙！）
* Enhance the database by helping out editing raw text. （请考虑帮忙扩充和修正题库。）
