<template>
    <el-container>
        <Header></Header>


        <el-main>
            <el-row>
                <el-col :span="3">&nbsp;</el-col>
                <el-col :span="5" v-for="(o, index) in 4" :key="o">
                    <el-card :body-style="{padding: '0px'}" style="margin:20px;width:300px" shadow="hover">
                        <img src="https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png" class="image">
                        <div style="padding: 14px;">
                            <span>Good burger</span>
                            <div class="bottom clearfix">
                                <time class="time">{{ currentDate }}</time>
                                <el-link type="primary">Management</el-link>
                            </div>
                        </div>
                    </el-card>
                </el-col>
                <el-col :span="3">&nbsp;</el-col>
            </el-row>
        </el-main>

        

        <el-footer>Footer</el-footer>
    </el-container>
</template>

<script>
    export default {
        name: 'Home',
        data() {
            return {
                currentDate: new Date()
            };
        },
        components: {

        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .el-header, .el-footer {
        background-color: #ffffff;
        color: #333;
        text-align: center;
        line-height: 60px;
    }

    .el-main {
        background-color: #ffffff;
        color: #333;
        text-align: center;
    }

    .el-row {
        margin-bottom: 0px;
    }

    .time {
        font-size: 13px;
        color: #999;
    }

    .button {
        padding: 0;
        float: right;
    }

    .image {
        width: 300px;
        height:168px;
        display: block;
    }

    .clearfix:before,
    .clearfix:after {
        display: table;
        content: "";
    }

    .clearfix:after {
        clear: both
    }
</style>

