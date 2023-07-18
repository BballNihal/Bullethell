
Page
3
of 4
// Exercise 1 
// ex1_vector.c
/* Include the system headers we need */
#include <stdlib.h>
#include <stdio.h>
typedef struct vector_t vector_t;
/* Define what our struct is */
struct vector_t {
    size_t size;
    int *data;
};
/* Utility function to handle allocation failures. In this
   case we print a message and exit. */
static void allocation_failed() {
    printf("Out of memory.\n");
    exit(1); //unsucessful termination. Program had to exit.
}
/* Bad example of how to create a new vector */
vector_t *bad_vector_create() {
    /* Create the vector and a pointer to it */
    vector_t * retval, v;
    retval = &v;
    /* Initialize attributes */
    retval->size = 1;
    retval->data[0] = 0;
    
    return retval;
}
/* Create a new vector with a size (length) of 1
   and set its single component to zero... the
   RIGHT WAY */
vector_t *vector_create() {
    /* Declare what this function will return */
    vector_t *retval;
    /* First, we need to allocate memory on the heap for the struct */
    retval = (vector_t*)malloc(sizeof(vector_t));
    /* Check our return value to make sure we got memory */
    if (retval == NULL) {
        allocation_failed();
    }
    /* Now we need to initialize our data.
       Since retval->data should be able to dynamically grow,
       what do you need to do? */
    retval->size = 1;
    retval->data = /** YOUR CODE HERE **/;
    /* Check the data attribute of our vector to make sure we got memory */
    if (retval->data == NULL) {
        free(retval);
        allocation_failed();
    }
    /* setting the single component to zero */
    retval->data[0] = 0;
    /* and return... */
    return retval;
}
/* Return the value at the specified location/component "loc" of the vector */
int vector_get(vector_t *v, size_t loc) {
    /* If we are passed a NULL pointer for our vector, complain about it and exit. 
*/
    if(/** YOUR CODE HERE **/) {
        printf("vector_get: passed a NULL vector.\n");
        abort(); //abort the program execution and come out directly from the place
of the call.       
    }
    /* If the requested location is higher than we have allocated, return 0.
     * Otherwise, return what is in the passed location.
     */
    if (loc < /* YOUR CODE HERE */) {
        return v->data[loc];
    } else {
        return 0;
    }    
}
/* Free up the memory allocated for the passed vector. */
void vector_delete(vector_t *v) {
    free(v->data);
    free(v);
}
/* Set a value in the vector. */
void vector_set(vector_t *v, size_t loc, int value) {
    /* What do you need to do if the location is greater than the size we have
     * allocated?  Remember that unset locations should contain a value of 0.
     */
    if(loc < /* YOUR CODE HERE */){
        v->data[loc] = value;
    } else { /* the location is greater than the size we have allocated */
        /* Please note that the following code and comments are just for reference.
         * If you have another way to finish this function and get correct output,
         * you can ignore the following code and comments. */
        /* 1. reallocate the array with new size */
        v->data = (int*)realloc(/* YOUR CODE HERE */);
        /* 2. initialize other elements to 0. Note that realloc() does not 
initialize 
         * element value, which means elements may not be 0 after realloc()  
         */
        /** YOUR SOLUTION HERE **/
        /* 3. store the value to the corresponding location (v->data[?] = ?)
         * 4. update the vector size (v->size = ?)
         */
        /** YOUR SOLUTION HERE **/ 
    }    
}
/* Main function. You can change the vector initialization to test the above f
   unctions. */
int main() {
    vector_t *v;
    printf("Calling vector_create()\n");
    v = vector_create();
    printf("Calling vector_delete()\n");
    vector_delete(v);
    printf("vector_create() again\n");
    v = vector_create();
    printf("These should all return 0 (vector_get()): ");
    printf("%d ", vector_get(v, 0));
    printf("%d ", vector_get(v, 1));
    printf("%d\n", vector_get(v, 2));
    printf("Doing a bunch of vector_set()s\n");
    vector_set(v, 0, 98);
    vector_set(v, 11, 15);
    vector_set(v, 15, -23);
    vector_set(v, 24, 65);
    vector_set(v, 500, 3);
    vector_set(v, 12, -123);
    vector_set(v, 15, 21);
    vector_set(v, 25, 43);
    printf("These should be equal:\n");
    printf("98 = %d\n", vector_get(v, 0));
    printf("15 = %d\n", vector_get(v, 11));
    printf("65 = %d\n", vector_get(v, 24));
    printf("-123 = %d\n", vector_get(v, 12));
    printf("21 = %d\n", vector_get(v, 15));
    printf("43 = %d\n", vector_get(v, 25));
    printf("0 = %d\n", vector_get(v, 23));
    printf("0 = %d\n", vector_get(v, 1));
    printf("0 = %d\n", vector_get(v, 501));
    printf("3 = %d\n", vector_get(v, 500));
    vector_delete(v);
    printf("Test complete.\n");
    return 0;
}
