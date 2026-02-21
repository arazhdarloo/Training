const data = require('../modules/friends.module')

const addFriend = (req, res) => {
    if (!req.body.name) {
        return res.status(400).json({
            error: "Missing friend name!"
        })
    }

    const friends = require('../modules/friends.module')


    const newFriend = {
        id: friends.friends.length,
        name: req.body.name
    }

    friends.friends.push(newFriend)
    res.json(newFriend)
}

const showFriends = (req, res) => {
    res.json(data)
}

const getSingleFriend = (req, res) => {
    const friendID = Number(req.params.friendID)
    const friend = data.friends[friendID]

    if (friend) {
        res.status(200).json(friend)
    } else {
        res.status(404).json({
            error: "friend doesn't exist"
        })
    }
}

module.exports = {
    addFriend,
    showFriends,
    getSingleFriend
}