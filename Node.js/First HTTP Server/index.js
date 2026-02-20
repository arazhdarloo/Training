const http = require("http")

const server = http.createServer()

const friends = [
    {
        id: 0,
        name: "Alireza"
    },
    {
        id: 1,
        name: "Reza"
    },
    {
        id: 2,
        name: "Ali"
    }
]

server.on('request', (req, res) => {
    item = req.url.split('/')
    if (req.method == "POST" && item[1] == "friends") {
        res.statusCode = 200
        req.on("data",(data)=>{
            const friend = data.toString()
            console.log(friend)
            friends.push(JSON.parse(friend))
            req.pipe(res)
        })
    }
    else if (req.method == "GET" && item[1] == "friends") {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'application/json')
        if (item.length == 3) {
            friendsIndex = Number(item[2])
            res.end(JSON.stringify(friends[friendsIndex]))
        } else {
            res.end(JSON.stringify(friends))
        }
    } else if (req.method == "GET" && item[1] == "messages") {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html')
        res.write("<html>")
        res.write("<body>")
        res.write("<ul>")
        res.write("<li>hello, this is first test message!</li>")
        res.write("<li>this is secound test message.</li>")
        res.write("</ul>")
        res.write("</body>")
        res.write("</html>")
        res.end()
    } else {
        res.statusCode = 404
        res.end()
    }
})

server.listen(3000, () => {
    console.log("listening on port 3000...")
})