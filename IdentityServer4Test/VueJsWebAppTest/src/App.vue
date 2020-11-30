<template>
    <div id="app">
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
    </div>
</template>

<script>
    import Header from './components/Header'
    

    export default {
        name: 'app',
        components: {
            Header
        }
    };
</script>

<style>
</style>

