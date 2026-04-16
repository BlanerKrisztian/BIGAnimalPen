const { Sequelize, DataTypes} = require('sequelize')
const dbHandler = new Sequelize('projekt','root',{
    host: "127.1.1.1",
    dialect: "mysql"
})

const userTable = dbHandler.define('user',{
    id:{
        type:DataTypes.UUID, //full random 128 bit
        defaultValue: DataTypes.UUIDV4, // 4th version of UUID generator
        allowNull: false,
        primaryKey: true
    },
    username:{
        type:DataTypes.STRING,
        allowNull:false
    },
    password:{
        type:DataTypes.STRING,
        allowNull:false,
    },
    createdtime:{
        type:DataTypes.DATE,
        allowNull:false,
    }

})

const userDataTable = dbHandler.define('userdata',{
    id:{
        type:DataTypes.UUID, //full random 128 bit
        defaultValue: DataTypes.UUIDV4, // 4th version of UUID generator
        allowNull: false,
        primaryKey: true
    },
    money:{
        type:DataTypes.INTEGER,
        allowNull:false,
        defaultValue: 100
    },
    level:{
        type:DataTypes.INTEGER,
        allowNull: false,
        defaultValue: 1
    },
    displayname:{
        type:DataTypes.STRING,
        allowNull:false,
        default: "UserUnnamed"
    },
    exp:{
        type:DataTypes.INTEGER,
        allowNull:false,
        defaultValue: 0
    },
    
})



userTable.hasOne(userDataTable) // connected the tables together
userDataTable.belongsTo(userTable)