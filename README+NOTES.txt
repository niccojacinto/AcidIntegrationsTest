Instructions: 
Run Database on localhost. (<- Serves no purpose at the moment)
start run.bat for easy testing.

Completion:
-Able to setup groundwork for Express
-Able to start database in localhost
-Able to access MongoDB through basic Node.js
-Started Foundation for Unity scripts and scene

===
Issues:
- accessing DB through Node fails after relocating installing locally

===
Next Iteration:
Unable to link Node.js to Express
Unable to link Express to MongoDB
Unable to link Unity to MongoDB
Unable to create any Front End program through React/Vue



This test consists of 3 parts. Unity, web and backend.

Part A - Backend
Build a simple Node.js/Express API server that accepts reads and updates a MongoDB database running at localhost. Add a data model that consists of a x, y,  and z for rotation speed, and a r, g and b values for color.

Part B - Web Frontend
Build a simple web interface for reading and modifying the data created in Part A. Nothing fancy, just needs to get the job done. Use a web framework (Vue or React).

Part C - Unity
Create a spinning, color changing cube inside of Unity. Read the values of the data in part A via the API you created to adjust the rotational velocity and color at a 1 second interval.

All components should run on localhost. I should be able to start the Part A server, Part B frontend and Part C Unity app and expect them to all work under these conditions.

Please submit in the form of a public repo on GitHub containing all three parts so that we may clone your repository and evaluate your work.

/*TODO*/:
[ ] Create Repo (skipped for now while learning about libs)
[ ] Run a MongoDB database on localhost
-	Managed to run MongoDB database
-	db.dropDatabase()
-	db.collectionName.drop()
-	document format:
o	{
index: 0,
rotSpeed: [x,y,z],
color: [r,g,b]

}
-	TODO: find way to auto index entries


[ ] Skim through Node.js server creation
[ ] Connect Node.js to MongoDB
[ ] Start a server using Node.js
[ ] Create a db/collection/document in Node.js to MongoDB
/*
Node.js version 4.0
Node.js uses MongoDB driver module to manipulate MongoDB databases

Last Update: Feb 28,2019
*/

// Use MongoDB driver
var MongoClient = require('mongodb').MongoClient;
// Connection URL
var url = 'mongodb://localhost:27017/acidIntegrationsDB';

//Connect to Database Location
MongoClient.connect(url, function(err, db) {
	// Create Database
	if (err) throw err;
	console.log("Created Database");
	var dbo = db.db("acidIntegrationsDB");

	// Create Collection
	dbo.createCollection("cubeTestData", function(err, res){
		if (err) throw err;
		console.log("Collection Created.")
	});

	// Insert Document
  	var mydata = { index: 0, val: 100 };
  	dbo.collection("cubeTestData").insertOne(mydata, function(err, res) {
    	if (err) throw err;
    	console.log("1 document inserted");
	});

  	// Close Database
    db.close();
});

*** Using Express was Recommended for better and more compact workflow

Day 1

[ ] Link MongoDB to Vue/React or Express?
[ ] (Express Built on top of Node)? ? Wrapper for Node so yes.


Actually Called MERN Stack? -> Might need an actual Junior Full Stack Developer instead of a specialized one.

Front-End    Back-End
React <-> Node/Express <-> MongoDB
           			|   
 		   	UNITY(?) (if Unity directly pulls from the DB)


[ ] Link UNITY to Express direct to database

-	Met Some problems with Node and Express..
-	People highly recommend using ide for scalability for Node+Express
[ ]Set-up Visual Studio for Node/Express Development

Note: config command ‘ npm install <packagename> --save ‘ to auto config with ide dependencies

[ ] Learn React (more modern) / Vue
-	Boilerplate code dependencies:
Babel ? dependency
Webpack ? dependency

[ ] Create Unity Scene/Script
-	Find/Write Plugin for MongoDB
[ ] Link React to Express
[ ] Link Express To MongoDB 
[ ] Link MongoDB to Unity


NTS: Need to learn React and Express the most 

https://scrimba.com/ - very good site, but maybe in the future
https://www.quora.com/What-should-I-learn-on-node-js-before-diving-into-Express-js
https://www.w3schools.com/nodejs/
https://stackoverflow.com/questions/28712248/difference-between-mongodb-and-mongoose
https://www.reddit.com/r/gamedev/comments/1iiur1/mongodb_in_unity/

?	mongoDB is native to mongoDB + mongoose is object modeling tool.. use mongoDB for simple tasks.

Might have to focus on Unity DB side.
Node.js said to have real-time capabilities so .. quite unsure whether I should hook up directly to the DB.
