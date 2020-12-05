<template>
    <el-menu :default-active="activeIndex" class="el-menu-demo" mode="horizontal" @select="handleSelect">
        <el-menu-item index="1">Management</el-menu-item>
        <el-submenu index="2">
            <template slot="title">
                My Workspace
            </template>
            <el-menu-item index="2-1">item1</el-menu-item>
            <el-menu-item index="2-2">item2</el-menu-item>
            <el-menu-item index="2-3">item3</el-menu-item>
            <el-submenu index="2-4">
                <template slot="title">
                    item4
                </template>
                <el-menu-item index="2-4-1">item1</el-menu-item>
                <el-menu-item index="2-4-2">item2</el-menu-item>
                <el-menu-item index="2-4-3">item3</el-menu-item>
            </el-submenu>
        </el-submenu>
        <el-menu-item index="3" disabled>Message</el-menu-item>
        <el-menu-item index="4"><a href="https://www.ele.me" target="_blank">Orders</a></el-menu-item>
    </el-menu>
</template>

<script>
</script>

<style scoped>
</style>