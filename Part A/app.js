/*
Node.js version 4.0


March 1, 2019

TODO : 
Find way to auto index documents/records
*/

// Node.js uses MongoDB driver module to manipulate MongoDB databases
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

	// Insert a test document
  	var mydata = { index: 0, val: 100 };

  	// var mydata = { index: 0, rotSpeed: [x,y,z], color: [r,g,b] };
  	dbo.collection("cubeTestData").insertOne(mydata, function(err, res) {
    	if (err) throw err;
    	console.log("1 document inserted");
	});

  	// Close Database
    db.close();
});
