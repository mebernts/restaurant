<template>
   <div>
       <v-row>
           <v-col>
               <AppertizerItem
               :id="appertizer.id"
               :name="appertizer.name"
               :description="appertizer.description"
               :allergies="appertizer.allergies"
               :price="appertizer.price"
               :imageSrc="appertizer.imageSrc"
               :category="appertizer.category"/>
           </v-col>
       </v-row>
   </div>
</template>

<script>
import axios from 'axios'
import AppertizerItem from './AppertizerItem.vue'
export default {
    data(){
        return{
            appertizers:[{id: 999, name: "TestName", description: "TestDiscription", allergies: "TestAllergies", price: 106, imageSrc:"", category:"testCategory"}]
        }
    }, // end data
    
    components:{
        AppertizerItem
    }
}
</script>

    