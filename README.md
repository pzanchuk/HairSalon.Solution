# _Hair Salon_

#### _03.01.2019_

#### By _**Pavel Zanchuk**_

## Description

_This program allows user to keep track of Clients and Stylists._

## Specifications

* _Program will accept user input for Stylist._
  * _Example input: "Pavel"._
  * _Example output: "Pavel"._

* _Program will accept user input for clients._
  * _Example input: "Panatda"._
  * _Example output: "Panatda"._

* _Program will accept user input for specialties._
  * _Example input: "Colorist"._
  * _Example output: "Colorist"._

* _Program will display in browser information about Stylist_
  * _Example input: click button "View all stylists" from home page, choose a stylist, details about that Stylist will be shown._
  * _Example output: info page about that Stylist will be shown._

* _Program will display in browser information about Specialties_
  * _Example input: click button "View all specialties" from home page, choose a specialty, details about that Specialty will be shown._
  * _Example output: info page about that Specialty will be shown._      

* _Program will display in browser information about Client_
  * _Example input: click button "View all stylists" from home page, choose a stylist, from the list click on any Client to show the details about that Client._
  * _Example output: info page about Client will be shown._

* _Program will edit information about Client_
  * _Example input: click button "View all stylists" from home page, choose a stylist, from the list click on any Client to show the details about that Client, click "Edit this Client"_
  * _Example output: form to change info will be shown._

* _Program will delete a single Client assigned to specific Stylist_
  * _Example input: click button "View all stylists" from home page, choose a stylist, from the list click on any Client to show the details about that Client, click "Delete this Client"_
  * _Example output: info page about Stylist that Client was assigned to will be shown._

* _Program will delete all Clients assigned to specific Stylist _
  * _Example input: click button "View all stylists" from home page, choose a stylist, click "Delete all clients"_
  * _Example output: info page about Stylist those Clients were assigned to will be shown._  

* _Program will edit information about Stylist_
  * _Example input: click button "View all stylists" from home page, choose a stylist, click "Edit this stylist"_
  * _Example output: form to change info will be shown._

* _Program will delete single Stylist_
  * _Example input: click button "View all stylists" from home page, choose a stylist, click "Delete this stylist"_
  * _Example output: list of current Stylists will be shown._

* _Program will delete all Stylists_
  * _Example input: click button "View all stylists" from home page, click "Delete all stylists"_
  * _Example output: list of current Stylists will be shown._       

## Setup/Installation Requirements
* _Navigate your web browser to https://github.com/pzanchuk/HairSalon.Solution_
* _Click the green button "Clone or download" on the repository page._
* _To download the repository choose "Open in Desktop" or "Download Zip"._
* _Alternatively, to clone the repository, type "git clone https://github.com/pzanchuk/HairSalon.Solution_ in the terminal". (Note!: git should be installed on your PC).  For more information visit GitHub Help section Cloning a repository from GitHub:
https://help.github.com/articles/cloning-a-repository-from-github/_
* _To run the project in browser: navigate to ../WordCounter.Solution/WordCounter and ran these lines to restore files "dotnet restore" and "dotnet build", then "dotnet run".(Note!: Mono and .NET Core SDK 1.1.4 must be installed on your machine". Open up web browser and connect to (http://localhost:5000/)_
* _To create database(MySQL should be installed): open up terminal and type in next lines:(Database is also included if you'd like to import it.)
CREATE DATABASE pavel_zanchuk;
USE pavel_zanchuk;
CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT);
CREATE TABLE specialties_stylists (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT);
CREATE TABLE specialties (id serial PRIMARY KEY, specialty_id INT, stylist_id INT);_

## Support and contact details

_For support please contact:_
_Pavel Zanchuk - buzzik@yahoo.com_

## Technologies Used

_This program was created using C# and MySql_

### License

*MIT License*

*Copyright (c) 2019 Pavel Zanchuk*

*Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*
