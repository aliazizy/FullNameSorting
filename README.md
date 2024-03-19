# Name Sorting

The Goal: Name Sorter
Given a set of names, order that set first by last name, then by any given names the person may have.<br/>
A name must have at least 1 given name and may have up to 3 given names.

**Example Usage**

Given a file unsorted-names-list.txt containing the following list of names:
>Janet Parsons<br/>
>Vaugh Lewis<br/>
>Adonis Julius Archer<br/>
>Shelby Nathan Yoder<br/>
>Marin Alvarez<br/>
>London Lindsey<br/>
>Beau Tristan Bentley<br/>
>Leo Gardner<br/>
>Hunter Uriah Mathew Clarke<br/>
>Mikayla Lopez<br/>
>Frankie Conner Ritter<br/>

Executing the program in the following way:
_name-sorter ./unsorted-names-list.txt_

Should result the sorted names to screen:

>Marin Alvarez<br/>
>Adonis Julius Archer<br/>
>Beau Tristan Bentley<br/>
>Hunter Uriah Mathew Clarke<br/>
>Leo Gardner<br/>
>Vaughn Lewis<br/>
>London Lindsey<br/>
>Mikayla Lopez<br/>
>Janet Parsons<br/>
>Frankie Conner Ritter<br/>
>Shelby Nathan Yoder<br/>

The program should also write the sorted names to a file called sorted-names-list.txt.

## CI/CD Pipeline
Using GitHub actions, a continuous integration (CI) workflow(Pipeline) has been added to build and run tests which could be found  [here](https://github.com/aliazizy/FullNameSorting/actions "here").<br/>
For example:<br/>
![GitHub CI/CD workflow](GitHubActionWorkflow.png "GitHub CI/CD workflow")
