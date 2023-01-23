# TakeHomeTest
Developer Candidate Take Home Test

-----------------
Considerations  
-----------------

When coding the project I tried to accommodate a completely generic solution. Meaning, the REST API could take any CSV formatted string and return 
the desired string format. To achieve this I created a custom Input Formatter to handle the deserialization of the input string, and then I configured 
the end point of the API to consume the defined custom input formatter.
For that reason the API expects a content type of “text/plain”. Sending a request with other content type would result on the API throwing an error of 
Media Type not Supported (415 error code).
At some point I considered using a less generic approach, since the input example resembles a object, there was also the option to create a Input Formatter 
what would parse the input into a model class, mapping each field to a class property. Since the requirements of the assignment don’t mentioned anything 
about having a fixed format for the input, I decided to go with the more generic solution.

--------------------------------
Regarding the implementation   
--------------------------------

The source code is written on C#, using .Net Core 6.0, with Visual Studio for Mac (although the Visual Studio version shouldn't really matter)

My goal when creating the solution was to achieve the requested functionality but also keep each class simple and concise. I am using dependency injection 
to achieve loose coupling, making the code more flexible. Taking that into consideration, I decided to create class to parse the input and another class 
to format the output, along with their respective interfaces. This allows for the code to be easily alter, if at some point the requirements change to 
include a different input or output format. The same logic applies for the validation class. The interface could be extended to validate different formats.
Additionally I create a API controller to handle validation errors, or any other kind on error on the application. A thrown exception would be handle by 
the Error Handler Controller, and present the error message to the user.
I also created a data transfer object to use it as data structure to store in memory a input line and the collection of words contained on that line. 
Again this could be less generic if we were dealing with parsing concrete classes instead of a generic CSV file.

Feel free to reach out if you have any questions or comments!
Oscar A.
