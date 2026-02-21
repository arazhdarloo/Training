const path = require('path')

const getMessages = (req, res)=>{
    res.render("messages",{
        friend: "Alireza",
        title: "message to my friend."
    })
    // res.sendFile(path.join(__dirname, "..", "public" , "tv.gif"))
}

module.exports = {
    getMessages
}