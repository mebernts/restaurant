<template>
    <nav>
        <v-toolbar color="blue-grey ">
            <v-icon color="white">mdi-crown</v-icon>
            <v-toolbar-title id="italy">Italia</v-toolbar-title>
            <v-icon color="white">mdi-crown</v-icon>
            <!--<v-icon>mdi-chef-hat</v-icon>-->
            <v-spacer></v-spacer>
            <v-btn class="mr-2" to="/">Hjem</v-btn>
            <v-btn class="mr-2" to="/about"> Om oss</v-btn>
            <v-btn to="/admin">Admin</v-btn>
            <!---- Kan endre knappen om til router-link om man vil eller legge inn v-icon-->
        </v-toolbar>
    </nav>
</template>

<style scoped>
#italy{
    /*font-family: 'Lora', serif;*/
    font-family: 'Dancing Script', cursive;
    font-size: 2.3rem;
    color: white;
}
</style>