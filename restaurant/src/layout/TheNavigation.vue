<template>
    <nav>
        <v-toolbar color="blue-grey darken-3">
            <v-icon color="white">mdi-crown</v-icon>
            <v-toolbar-title id="italy" class="white--text">Italia</v-toolbar-title>
            <v-icon color="white">mdi-crown</v-icon>
            <v-spacer></v-spacer>
            <v-btn class="mr-2" to="/">Hjem</v-btn>
            <v-btn class="mr-2" to="/menu">Meny</v-btn>
            <v-btn class="mr-2" to="/about"> Om oss</v-btn>
            <v-btn to="/admin">Admin</v-btn>
        </v-toolbar>
    </nav>
</template>

<style scoped>
#italy{
    font-family: 'Dancing Script', cursive;
    font-size: 2.3rem;
}
</style>