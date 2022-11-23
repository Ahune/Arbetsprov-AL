### Key Take aways

#### The Applicaiton does not handel errors due to there are multiple ways of handling web request errors and what status codes to return when somthing goes wrong.

- My take would to always return bad request 500 instead of appropriate status codes. Mostly because appropriate status codes can give intruders information on internal code and hints on how to expose the application.

- If I was to add a decimal value on the json body, let's say 2.5 this will result in a bad request, and some exception coming back from my application telling me what I tried to pass is not possible due to converting issues.

#### The application does not include unit-testing, this is a very good feature to have in the application.

- Reason why it would be very good is not because of code coverage. Many project leaders and "business people" strongly believes in a high number of code coverage on unit tests. In my opinion which I very gladly like to argument on why unit testing are good in this type of project is mostly because of new modifications / when extending the application with some type of architecture design pattern like MVC, MVVM or Clean architecture (DDD).Unit testing allows us to be more weary of the effects our new changes affect the application. It notifies if our functionality get broken.
- How much coverage of unit testing would I have ideally on an application like this depends on how many times i reuse and override the interface methods. Creating unit testing on the methods that are reused, overwritten holds business logic is where id write my unit tests on. Anything else I would not unit test mostly because its highly likely to be a waste of time. (again this is my opinion)  

- Unit testing web request, is a no, mostly because it does not count as business logic. But methods that transform the request response is worth unit testing. 




