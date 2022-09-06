const fs = require('fs'); 
const { parse } = require('csv-parse');

//Get the arguments passed from the command line
path = process.argv[2];
column = process.argv[3];
key = process.argv[4];

//Create a stream to read the data
fs.createReadStream(path)
    .pipe(parse({delimiter: [',']})) //Use a parser to parse the records
    .on('data', function(row) {
			if(row[column] == key){ //If the data at the specified column matches the key, the record will be printed as a string
        console.log(row.join());
			}
    })