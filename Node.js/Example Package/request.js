const axios = require('axios')

axios.get("https://www.google.com")
    .then((Response)=>{
        console.log(Response)
    })
    .catch((Error)=>{
        console.log(Error)
    })
    .then(()=>{
        console.log("all done!")
    })