<template>
    <el-header>
        <el-row>
            <el-col :span="3">&nbsp;</el-col>
            <el-col :span="3">
                <div class="grid-content bg-purple">
                    Test Logo
                </div>
            </el-col>
            <el-col :span="12">
                <div class="grid-content bg-purple-light">
                    &nbsp;
                </div>
            </el-col>
            <el-col :span="3">
                <div class="grid-content bg-purple-light" style="text-align:right">
                    <el-link type="primary" href="https://localhost:5001/Account/Login" style="margin-right:30px">Sign in</el-link>
                    <el-button size="mini">Sign up</el-button>
                </div>
            </el-col>
            <el-col :span="3">&nbsp;</el-col>
        </el-row>
    </el-header>
</template>

<script>
    export default {
        name:'Header'
    }
</script>

<style scoped>
    .el-header {
        background-color: #ffffff;
        color: #333;
        text-align: center;
        line-height: 60px;
    }
</style>