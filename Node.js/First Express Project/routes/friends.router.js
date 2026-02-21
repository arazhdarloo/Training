const express = require("express")
const friendsController = require("./../controllers/friends.controller")

const friendsRouter = express.Router();

friendsRouter.post('/', friendsController.addFriend)
friendsRouter.get('/', friendsController.showFriends)
friendsRouter.get('/:friendID', friendsController.getSingleFriend)

module.exports = friendsRouter