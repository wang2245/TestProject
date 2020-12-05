<template>
    <el-col :span="24">
        <h5>Default Color</h5>
        <el-menu default-active="2"
                 class="el-menu-vertical-demo"
                 @open="handleOpen"
                 @close="handleClose">
            <el-submenu index="1">
                <template slot="title">
                    <i class="el-icon-location"></i>
                    <span>Nav1</span>
                </template>
                <el-menu-item-group>
                    <template slot="title">
                        Group1
                    </template>
                    <el-menu-item index="1-1">item1</el-menu-item>
                    <el-menu-item index="1-2">item2</el-menu-item>
                </el-menu-item-group>
                <el-menu-item-group title="group2">
                    <el-menu-item index="1-3">item3</el-menu-item>
                </el-menu-item-group>
                <el-submenu index="1-4">
                    <template slot="title">
                        item4
                    </template>
                    <el-menu-item index="1-4-1">item1</el-menu-item>
                </el-submenu>
            </el-submenu>
            <el-menu-item index="2">
                <i class="el-icon-menu"></i>
                <span slot="title">Nav2</span>
            </el-menu-item>
            <el-menu-item index="3" disabled>
                <i class="el-icon-document"></i>
                <span slot="title">Nav3</span>
            </el-menu-item>
            <el-menu-item index="4">
                <i class="el-icon-setting"></i>
                <span slot="title">Settings</span>
            </el-menu-item>
        </el-menu>
    </el-col>
</template>

<script>
    export default {
        methods: {
            handleOpen(key, keyPath) {
                console.log(key, keyPath);
            },
            handleClose(key, keyPath) {
                console.log(key, keyPath);
            }
        }
    }
</script>

<style scoped>
</style>