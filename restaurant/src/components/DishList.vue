<template>
   <div>
       <v-row>
           <v-col cols="12" sm="6" lg="4" v-for="dish in dishes" :key="dish.id">
               <DishItem 
               :id="dish.id"
               :name="dish.name"
               :description="dish.description"
               :allergies="dish.allergies"
               :price="dish.price"
               :imageSrc="dish.imageSrc"
               :category="dish.category"/>
           </v-col>
       </v-row>
   </div>
</template>

<script>
import axios from 'axios'
import DishItem from './DishItem.vue'
export default {
    data(){
        return{
            Dishes:[{id: 100, name: "TestName", description: "TestDiscription", allergies: "TestAllergies", price: 100, imageSrc:"", category:"testCategory"}]
        }
    },
    created(){
        axios.get("https://localhost:5001/resturant/dishes")
        .then(result =>{
            console.log(result.data);
            this.dishes = result.data;
        }) // axios that gets information from the database
    },
    components:{
        DishItem
    }
}
</script>
