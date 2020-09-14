# CivilServiceTest
This is an API which calls the API at https://bpdts-test-app.herokuapp.com/, and returns people who are listed as either living in London, or whose current coordinates are within 50 miles of London. 

Initially, the City endpoint was used to try and return the users from city: London, however - the co-ordinates of those users did not match the location of London. Therefore, the users endpoint was used and the centre of London was assumed as the location from which to search within a 50 mile radius. 

