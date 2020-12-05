<template>
    <div id="app">
            <el-main>
                <el-row>
                    <TopNav></TopNav>
                </el-row>
                <el-row>
                    <el-col :span="4">
                        <LeftNav></LeftNav>
                    </el-col>
                    <el-col :span="20">
                        <router-view></router-view>
                    </el-col>
                </el-row>
            </el-main>
    </div>
</template>

<script>
    import Header from './components/Header'
    import TopNav from './components/TopNav'
    import LeftNav from './components/LeftNav'

    export default {
        name: 'app',
        components: {
            Header,
            LeftNav,
            TopNav
        }
    };
</script>

<style>
</style>

