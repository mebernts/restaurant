<template>
   <div>
       <v-row>
           <v-col>
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
    }, // end data
    
    components:{
        DishItem
    }
}
</script>
